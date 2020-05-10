#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Internal
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IVisualInternal 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		float RasterizationScaleOverride
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Internal.IVisualInternal.RasterizationScaleOverride.get
		// Forced skipping of method Microsoft.UI.Composition.Internal.IVisualInternal.RasterizationScaleOverride.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.IAsyncOperation<global::Microsoft.UI.Composition.ICompositionSurface> CaptureAsync( global::Microsoft.UI.Composition.Visual propertyVisual,  global::Microsoft.UI.Composition.CompositionGraphicsDevice graphicsDevice,  int width,  int height,  global::Windows.Graphics.DirectX.DirectXPixelFormat pixelFormat,  global::Windows.Graphics.DirectX.DirectXAlphaMode alphaMode);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		long GetInputSinkHandle();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetInputSinkHandle( long inputHandle);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetParentForTransformFromReference( global::Microsoft.UI.Composition.Internal.VisualReference value);
		#endif
	}
}
