#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IWindowPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool TransparentBackground
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.IWindowPrivate.TransparentBackground.get
		// Forced skipping of method Microsoft.UI.Xaml.IWindowPrivate.TransparentBackground.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void Show();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void Hide();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void MoveWindow( int x,  int y,  int width,  int height);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetAtlasSizeHint( uint width,  uint height);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void ReleaseGraphicsDeviceOnSuspend( bool enable);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetAtlasRequestCallback( global::Microsoft.UI.Xaml.IAtlasRequestCallback callback);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetSynchronizationInfo( ulong compSyncObject,  ulong commitResizeWindow);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Rect GetWindowContentBoundsForElement( global::Microsoft.UI.Xaml.DependencyObject element);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Rect GetWindowContentLayoutBoundsForElement( global::Microsoft.UI.Xaml.DependencyObject element);
		#endif
	}
}
