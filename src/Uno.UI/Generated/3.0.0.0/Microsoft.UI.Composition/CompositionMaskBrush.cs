#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionMaskBrush : global::Microsoft.UI.Composition.CompositionBrush
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionBrush Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush CompositionMaskBrush.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionMaskBrush", "CompositionBrush CompositionMaskBrush.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionBrush Mask
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush CompositionMaskBrush.Mask is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionMaskBrush", "CompositionBrush CompositionMaskBrush.Mask");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionMaskBrush.Mask.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionMaskBrush.Mask.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionMaskBrush.Source.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionMaskBrush.Source.set
	}
}