#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct LayoutReference 
	{
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutReference.LayoutReference()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::Microsoft.UI.Xaml.Controls.ReferenceIdentity RelativeLocation;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::Windows.Foundation.Rect ReferenceBounds;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::Windows.Foundation.Rect HeaderBounds;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  bool ReferenceIsHeader;
		#endif
	}
}
