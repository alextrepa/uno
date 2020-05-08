#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IElementFactoryShim 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.UIElement GetElement( global::Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void RecycleElement( global::Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs args);
		#endif
	}
}
