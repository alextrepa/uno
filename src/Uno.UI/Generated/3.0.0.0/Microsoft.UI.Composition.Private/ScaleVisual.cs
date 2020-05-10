#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScaleVisual : global::Microsoft.UI.Composition.ContainerVisual
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Private.CompositionResampleMode ResampleMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionResampleMode ScaleVisual.ResampleMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Private.ScaleVisual", "CompositionResampleMode ScaleVisual.ResampleMode");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Private.ScaleVisual.ResampleMode.get
		// Forced skipping of method Microsoft.UI.Composition.Private.ScaleVisual.ResampleMode.set
	}
}
