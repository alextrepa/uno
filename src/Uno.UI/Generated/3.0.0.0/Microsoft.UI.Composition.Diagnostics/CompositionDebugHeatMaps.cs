#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionDebugHeatMaps 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Hide( global::Microsoft.UI.Composition.Visual subtree)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Diagnostics.CompositionDebugHeatMaps", "void CompositionDebugHeatMaps.Hide(Visual subtree)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ShowMemoryUsage( global::Microsoft.UI.Composition.Visual subtree)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Diagnostics.CompositionDebugHeatMaps", "void CompositionDebugHeatMaps.ShowMemoryUsage(Visual subtree)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ShowOverdraw( global::Microsoft.UI.Composition.Visual subtree,  global::Microsoft.UI.Composition.Diagnostics.CompositionDebugOverdrawContentKinds contentKinds)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Diagnostics.CompositionDebugHeatMaps", "void CompositionDebugHeatMaps.ShowOverdraw(Visual subtree, CompositionDebugOverdrawContentKinds contentKinds)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ShowRedraw( global::Microsoft.UI.Composition.Visual subtree)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Diagnostics.CompositionDebugHeatMaps", "void CompositionDebugHeatMaps.ShowRedraw(Visual subtree)");
		}
		#endif
	}
}