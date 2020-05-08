#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITransitionPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void CreateStoryboard( global::Microsoft.UI.Xaml.UIElement element,  global::Windows.Foundation.Rect start,  global::Windows.Foundation.Rect destination,  global::Microsoft.UI.Xaml.TransitionTrigger transitionTrigger,  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Media.Animation.Storyboard> storyboards, out global::Microsoft.UI.Xaml.TransitionParent parentForTransition);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool ParticipatesInTransition( global::Microsoft.UI.Xaml.UIElement element,  global::Microsoft.UI.Xaml.TransitionTrigger transitonTrigger);
		#endif
	}
}
