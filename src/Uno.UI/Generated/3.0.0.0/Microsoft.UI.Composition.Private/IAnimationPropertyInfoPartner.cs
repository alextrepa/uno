#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IAnimationPropertyInfoPartner 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionObject ResolvedCompositionObject
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		string ResolvedCompositionObjectProperty
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Private.IAnimationPropertyInfoPartner.ResolvedCompositionObject.get
		// Forced skipping of method Microsoft.UI.Composition.Private.IAnimationPropertyInfoPartner.ResolvedCompositionObjectProperty.get
	}
}