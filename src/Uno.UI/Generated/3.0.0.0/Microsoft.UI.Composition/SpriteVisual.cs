#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpriteVisual : global::Microsoft.UI.Composition.ContainerVisual
	{
		// Skipping already declared property Brush
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionShadow Shadow
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionShadow SpriteVisual.Shadow is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.SpriteVisual", "CompositionShadow SpriteVisual.Shadow");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.SpriteVisual.Brush.get
		// Forced skipping of method Microsoft.UI.Composition.SpriteVisual.Brush.set
		// Forced skipping of method Microsoft.UI.Composition.SpriteVisual.Shadow.get
		// Forced skipping of method Microsoft.UI.Composition.SpriteVisual.Shadow.set
	}
}