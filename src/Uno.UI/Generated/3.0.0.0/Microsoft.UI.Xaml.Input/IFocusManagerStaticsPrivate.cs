#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IFocusManagerStaticsPrivate 
	{
		// Forced skipping of method Microsoft.UI.Xaml.Input.IFocusManagerStaticsPrivate.FocusedElementRemoved.add
		// Forced skipping of method Microsoft.UI.Xaml.Input.IFocusManagerStaticsPrivate.FocusedElementRemoved.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		object FindNextFocusWithSearchRootIgnoreEngagement( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection,  object searchRoot);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		object FindNextFocusWithSearchRootIgnoreEngagementWithHintRect( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection,  object searchRoot,  global::Windows.Foundation.Rect hintRect,  global::Windows.Foundation.Rect exclusionRect);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		object FindNextFocusWithSearchRootIgnoreEngagementWithClip( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection,  object searchRoot,  bool ignoreClipping,  bool ignoreCone);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetEngagedControl( object engagedControl);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool SetFocusedElement( global::Microsoft.UI.Xaml.DependencyObject element,  global::Microsoft.UI.Xaml.FocusState focusState,  bool animateIfBringIntoView,  bool forceBringIntoView,  bool isProcessingTab,  bool isShiftPressed);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool SetFocusedElement( global::Microsoft.UI.Xaml.DependencyObject element,  global::Microsoft.UI.Xaml.FocusState focusState,  bool animateIfBringIntoView,  bool forceBringIntoView,  global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Microsoft.UI.Xaml.Input.FocusedElementRemovedEventHandler FocusedElementRemoved;
		#endif
	}
}
