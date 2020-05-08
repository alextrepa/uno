#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IVisualPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Private.CompositionDepthMode DepthMode
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool DisconnectChildrenOnDestroy
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsTransparentForInput
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool ProtectContents
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::System.Numerics.Vector3 UpVectorOverride
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.DepthMode.get
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.DepthMode.set
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.DisconnectChildrenOnDestroy.get
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.DisconnectChildrenOnDestroy.set
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.IsTransparentForInput.get
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.IsTransparentForInput.set
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.ProtectContents.get
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.ProtectContents.set
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.UpVectorOverride.get
		// Forced skipping of method Microsoft.UI.Composition.Private.IVisualPrivate.UpVectorOverride.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void AttachMouseDragToHwnd( long hwnd,  bool enable);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void AttachMouseWheelToHwnd( long hwnd,  bool enable);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.IAsyncOperation<global::Microsoft.UI.Composition.ICompositionSurface> CaptureOverrideSDRBoostAsync( global::Microsoft.UI.Composition.Visual propertyVisual,  global::Microsoft.UI.Composition.CompositionGraphicsDevice graphicsDevice,  int width,  int height,  global::Windows.Graphics.DirectX.DirectXPixelFormat pixelFormat,  global::Windows.Graphics.DirectX.DirectXAlphaMode alphaMode,  float sdrBoost);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		long GetClosedEventHandle();
		#endif
	}
}
