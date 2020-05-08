#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionPathGeometry : global::Microsoft.UI.Composition.CompositionGeometry
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionPath Path
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionPath CompositionPathGeometry.Path is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionPathGeometry", "CompositionPath CompositionPathGeometry.Path");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionPathGeometry.Path.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionPathGeometry.Path.set
	}
}
