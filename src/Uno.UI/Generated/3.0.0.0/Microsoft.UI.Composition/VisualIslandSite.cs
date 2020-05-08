#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class VisualIslandSite : global::Microsoft.UI.Composition.CompositionIslandSite,global::Microsoft.UI.Composition.ICompositionIslandSite
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsSiteVisible
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool VisualIslandSite.IsSiteVisible is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.VisualIslandSite", "bool VisualIslandSite.IsSiteVisible");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 ActualSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 VisualIslandSite.ActualSize is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.VisualIslandSite", "Vector2 VisualIslandSite.ActualSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 RequestedSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 VisualIslandSite.RequestedSize is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Visual SiteVisual
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual VisualIslandSite.SiteVisual is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.VisualIslandSite.ActualSize.get
		// Forced skipping of method Microsoft.UI.Composition.VisualIslandSite.ActualSize.set
		// Forced skipping of method Microsoft.UI.Composition.VisualIslandSite.IsSiteVisible.get
		// Forced skipping of method Microsoft.UI.Composition.VisualIslandSite.IsSiteVisible.set
		// Forced skipping of method Microsoft.UI.Composition.VisualIslandSite.RequestedSize.get
		// Forced skipping of method Microsoft.UI.Composition.VisualIslandSite.SiteVisual.get
		// Forced skipping of method Microsoft.UI.Composition.VisualIslandSite.RequestedSizeChanged.add
		// Forced skipping of method Microsoft.UI.Composition.VisualIslandSite.RequestedSizeChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionNotificationDeferral CreateTransformChangedDeferral()
		{
			throw new global::System.NotImplementedException("The member CompositionNotificationDeferral VisualIslandSite.CreateTransformChangedDeferral() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Composition.VisualIslandSite, global::Microsoft.UI.Composition.VisualIslandSiteEventArgs> RequestedSizeChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.VisualIslandSite", "event TypedEventHandler<VisualIslandSite, VisualIslandSiteEventArgs> VisualIslandSite.RequestedSizeChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.VisualIslandSite", "event TypedEventHandler<VisualIslandSite, VisualIslandSiteEventArgs> VisualIslandSite.RequestedSizeChanged");
			}
		}
		#endif
		// Processing: Microsoft.UI.Composition.ICompositionIslandSite
	}
}
