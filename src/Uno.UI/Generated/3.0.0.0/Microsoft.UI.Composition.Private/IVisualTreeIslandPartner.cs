#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IVisualTreeIslandPartner 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Visual ContentVisual
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualTreeIslandPartner.ContentVisual.get
	}
}
