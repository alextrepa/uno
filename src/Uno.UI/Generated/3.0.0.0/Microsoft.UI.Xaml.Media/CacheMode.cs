#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CacheMode : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		protected CacheMode() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.CacheMode", "CacheMode.CacheMode()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.CacheMode.CacheMode()
	}
}
