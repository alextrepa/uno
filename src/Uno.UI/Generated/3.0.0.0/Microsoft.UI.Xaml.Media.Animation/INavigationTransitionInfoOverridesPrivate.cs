#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface INavigationTransitionInfoOverridesPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void CreateStoryboardsCore( global::Microsoft.UI.Xaml.UIElement element,  global::Microsoft.UI.Xaml.Media.Animation.NavigationTrigger trigger,  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Media.Animation.Storyboard> storyboards);
		#endif
	}
}
