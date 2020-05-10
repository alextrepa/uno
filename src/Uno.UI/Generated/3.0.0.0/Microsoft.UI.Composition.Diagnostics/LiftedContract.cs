#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct LiftedContract 
	{
		// Forced skipping of method Microsoft.UI.Composition.Diagnostics.LiftedContract.LiftedContract()
	}
}
