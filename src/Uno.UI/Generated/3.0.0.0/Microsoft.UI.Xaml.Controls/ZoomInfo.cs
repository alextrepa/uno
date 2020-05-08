#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct ZoomInfo 
	{
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomInfo.ZoomInfo()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  int ZoomFactorChangeId;
		#endif
	}
}
