#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionIslandSite : global::Microsoft.UI.Composition.CompositionObject,global::Microsoft.UI.Composition.ICompositionIslandSite
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionNotificationDeferral CreateTransformChangedDeferral()
		{
			throw new global::System.NotImplementedException("The member CompositionNotificationDeferral CompositionIslandSite.CreateTransformChangedDeferral() is not implemented in Uno.");
		}
		#endif
		// Processing: Microsoft.UI.Composition.ICompositionIslandSite
	}
}
