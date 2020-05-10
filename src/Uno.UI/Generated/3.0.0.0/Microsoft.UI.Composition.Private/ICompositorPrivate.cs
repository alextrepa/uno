#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICompositorPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		uint CurrentBatchId
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		uint LastConfirmedBatchId
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Private.ICompositorPrivate.CurrentBatchId.get
		// Forced skipping of method Microsoft.UI.Composition.Private.ICompositorPrivate.LastConfirmedBatchId.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.AnimationPropertyInfo CreateAnimationPropertyInfo();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Private.CompositionCubeMap CreateCubeMap( uint size,  uint mipLevels,  bool automaticMipmaps);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Private.DataSourceReader CreateDataSourceReader( ulong providerId,  ulong dataSourceId);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Private.RectangleClip CreateRectangleClip();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Private.RectangleClip CreateRectangleClip( float left,  float top,  float right,  float bottom);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Private.RectangleClip CreateRectangleClip( float left,  float top,  float right,  float bottom,  global::System.Numerics.Vector2 topLeftRadius,  global::System.Numerics.Vector2 topRightRadius,  global::System.Numerics.Vector2 bottomLeftRadius,  global::System.Numerics.Vector2 bottomRightRadius);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Private.ScaleVisual CreateScaleVisual();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Private.CompositionSkyBoxBrush CreateSkyBoxBrush();
		#endif
	}
}
