#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IXamlCompositionBrushBasePrivates 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetBrushForXamlRoot( object xamlRoot,  global::Microsoft.UI.Composition.CompositionBrush brush);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionBrush GetBrushForXamlRoot( object xamlRoot);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void ClearBrushForXamlRoot( object xamlRoot,  global::Microsoft.UI.Composition.CompositionBrush brush);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void ClearCompositionBrushMap();
		#endif
	}
}
