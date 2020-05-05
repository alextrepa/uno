#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Imaging
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SurfaceImageSource : global::Microsoft.UI.Xaml.Media.ImageSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SurfaceImageSource( int pixelWidth,  int pixelHeight) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Imaging.SurfaceImageSource", "SurfaceImageSource.SurfaceImageSource(int pixelWidth, int pixelHeight)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.SurfaceImageSource.SurfaceImageSource(int, int)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SurfaceImageSource( int pixelWidth,  int pixelHeight,  bool isOpaque) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Imaging.SurfaceImageSource", "SurfaceImageSource.SurfaceImageSource(int pixelWidth, int pixelHeight, bool isOpaque)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.SurfaceImageSource.SurfaceImageSource(int, int, bool)
	}
}