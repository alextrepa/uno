using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Uno.UI.Samples.Controls;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Uno.Extensions;

namespace Uno.UI.Samples.UITests.ImageTestsControl
{
	[SampleControlInfo("Image", "LoadFromBytes")]
	public sealed partial class LoadFromBytes
	{
		public LoadFromBytes()
		{
			InitializeComponent();
			Loaded += OnLoaded;
		}

		private async void OnLoaded(object sender, RoutedEventArgs e)
		{
			var assembly = typeof(LoadFromBytes).Assembly;

			var query = from name in assembly.GetManifestResourceNames()
						where name.EndsWith("mslug.png")
						select assembly.GetManifestResourceStream(name);

			using (var stream = query.First())
			{
				MyImage.Source = await CreateImageSource(stream);
			}
		}

		private async Task<ImageSource> CreateImageSource(Stream stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException(nameof(stream));
			}

			var image = new BitmapImage();

#if WINDOWS_UWP
			await image.SetSourceAsync(stream.AsRandomAccessStream()).AsTask();
#else
			var copy = stream.ToMemoryStream();
			await image.SetSourceAsync(copy);
#endif
			return image;
		}
	}
}
