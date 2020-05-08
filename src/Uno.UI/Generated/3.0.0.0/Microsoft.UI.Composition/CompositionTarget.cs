#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionTarget : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Visual Root
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual CompositionTarget.Root is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionTarget", "Visual CompositionTarget.Root");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionTarget.Root.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionTarget.Root.set
	}
}
