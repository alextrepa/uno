#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PopupIslandSite : global::Microsoft.UI.Composition.CompositionIslandSite
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 PlacementAnchorPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 PopupIslandSite.PlacementAnchorPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.PopupIslandSite", "Vector2 PopupIslandSite.PlacementAnchorPoint");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionAnchor PlacementAnchor
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionAnchor PopupIslandSite.PlacementAnchor is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.PopupIslandSite", "CompositionAnchor PopupIslandSite.PlacementAnchor");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.PopupIslandSite.PlacementAnchor.get
		// Forced skipping of method Microsoft.UI.Composition.PopupIslandSite.PlacementAnchor.set
		// Forced skipping of method Microsoft.UI.Composition.PopupIslandSite.PlacementAnchorPoint.get
		// Forced skipping of method Microsoft.UI.Composition.PopupIslandSite.PlacementAnchorPoint.set
	}
}
