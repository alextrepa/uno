#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IAnimatedVisualSource 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual( global::Microsoft.UI.Composition.Compositor compositor, out object diagnostics);
		#endif
	}
}