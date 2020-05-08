#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SolidColorBrush : global::Microsoft.UI.Xaml.Media.Brush
	{
		// Skipping already declared property Color
		// Skipping already declared property ColorProperty
		#if __ANDROID__ || __IOS__ || false || false || false
		[global::Uno.NotImplemented]
		public SolidColorBrush( global::Windows.UI.Color color) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.SolidColorBrush", "SolidColorBrush.SolidColorBrush(Color color)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.SolidColorBrush.SolidColorBrush(Windows.UI.Color)
		// Skipping already declared method Microsoft.UI.Xaml.Media.SolidColorBrush.SolidColorBrush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.SolidColorBrush.SolidColorBrush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.SolidColorBrush.Color.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.SolidColorBrush.Color.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.SolidColorBrush.ColorProperty.get
	}
}
