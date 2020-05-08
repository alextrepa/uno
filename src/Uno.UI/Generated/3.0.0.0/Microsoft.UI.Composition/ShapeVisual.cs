#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ShapeVisual : global::Microsoft.UI.Composition.ContainerVisual
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionViewBox ViewBox
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionViewBox ShapeVisual.ViewBox is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.ShapeVisual", "CompositionViewBox ShapeVisual.ViewBox");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionShapeCollection Shapes
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionShapeCollection ShapeVisual.Shapes is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.ShapeVisual.Shapes.get
		// Forced skipping of method Microsoft.UI.Composition.ShapeVisual.ViewBox.get
		// Forced skipping of method Microsoft.UI.Composition.ShapeVisual.ViewBox.set
	}
}
