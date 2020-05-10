#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Internal
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICompositionVisualSurfacePartner 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::System.Numerics.Vector2 RealizationSize
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionStretch Stretch
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Internal.ICompositionVisualSurfacePartner.RealizationSize.get
		// Forced skipping of method Microsoft.UI.Composition.Internal.ICompositionVisualSurfacePartner.RealizationSize.set
		// Forced skipping of method Microsoft.UI.Composition.Internal.ICompositionVisualSurfacePartner.Stretch.get
		// Forced skipping of method Microsoft.UI.Composition.Internal.ICompositionVisualSurfacePartner.Stretch.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void Freeze();
		#endif
	}
}
