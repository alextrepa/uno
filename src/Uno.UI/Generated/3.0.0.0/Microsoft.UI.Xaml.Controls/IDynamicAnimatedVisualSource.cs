#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IDynamicAnimatedVisualSource : global::Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
	{
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IDynamicAnimatedVisualSource.AnimatedVisualInvalidated.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IDynamicAnimatedVisualSource.AnimatedVisualInvalidated.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.IDynamicAnimatedVisualSource, object> AnimatedVisualInvalidated;
		#endif
	}
}
