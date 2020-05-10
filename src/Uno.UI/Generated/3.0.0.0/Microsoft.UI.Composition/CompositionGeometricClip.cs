#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionGeometricClip : global::Microsoft.UI.Composition.CompositionClip
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionViewBox ViewBox
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionViewBox CompositionGeometricClip.ViewBox is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionGeometricClip", "CompositionViewBox CompositionGeometricClip.ViewBox");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionGeometry Geometry
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionGeometry CompositionGeometricClip.Geometry is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionGeometricClip", "CompositionGeometry CompositionGeometricClip.Geometry");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionGeometricClip.Geometry.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionGeometricClip.Geometry.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionGeometricClip.ViewBox.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionGeometricClip.ViewBox.set
	}
}
