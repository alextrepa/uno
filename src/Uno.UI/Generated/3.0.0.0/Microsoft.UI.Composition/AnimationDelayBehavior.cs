#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public   enum AnimationDelayBehavior 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		SetInitialValueAfterDelay,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		SetInitialValueBeforeDelay,
		#endif
	}
	#endif
}
