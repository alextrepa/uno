#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IFrameworkApplicationPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void StartOnCurrentThread( global::Microsoft.UI.Xaml.ApplicationInitializationCallback callback);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Hosting.XamlIsland CreateIsland();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Hosting.XamlIsland CreateIslandWithContentBridge( object owner,  object contentBridge);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void RemoveIsland( global::Microsoft.UI.Xaml.Hosting.XamlIsland island);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetSynchronizationWindow( ulong commitResizeWindow);
		#endif
	}
}
