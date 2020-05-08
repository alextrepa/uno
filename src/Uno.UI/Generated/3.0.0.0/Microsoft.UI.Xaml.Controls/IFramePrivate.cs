#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IFramePrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void GetNavigationTransitionInfoOverride(out global::Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo infoOverride, out bool isBackNavigation, out bool isInitialPage);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetNavigationTransitionInfoOverride( global::Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo infoOverride);
		#endif
	}
}
