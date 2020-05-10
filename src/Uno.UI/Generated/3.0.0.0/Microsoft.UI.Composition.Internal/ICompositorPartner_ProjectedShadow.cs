#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Internal
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICompositorPartner_ProjectedShadow 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionProjectedShadowCaster CreateSharedClientProjectedShadowCaster();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionProjectedShadowCaster CreateSharedHostProjectedShadowCaster();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionProjectedShadowCaster OpenClientProjectedShadowCasterFromHandle( ulong handle);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionProjectedShadowCaster OpenHostProjectedShadowCasterFromHandle( ulong handle);
		#endif
	}
}
