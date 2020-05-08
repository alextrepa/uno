#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct EstimationReference 
	{
		// Forced skipping of method Microsoft.UI.Xaml.Controls.EstimationReference.EstimationReference()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::Microsoft.UI.Xaml.Controls.ElementType ElementType;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  int ElementIndex;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  global::Windows.Foundation.Rect ElementBounds;
		#endif
	}
}
