#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IScrollController 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool AreInteractionsAllowed
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool AreScrollerInteractionsAllowed
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Visual InteractionVisual
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.Orientation InteractionVisualScrollOrientation
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsInteracting
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsInteractionVisualRailEnabled
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.AreInteractionsAllowed.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.AreScrollerInteractionsAllowed.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.IsInteracting.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.IsInteractionVisualRailEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionVisual.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionVisualScrollOrientation.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetExpressionAnimationSources( global::Microsoft.UI.Composition.CompositionPropertySet propertySet,  string minOffsetPropertyName,  string maxOffsetPropertyName,  string offsetPropertyName,  string multiplierPropertyName);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetScrollMode( global::Microsoft.UI.Xaml.Controls.ScrollMode scrollMode);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetValues( double minOffset,  double maxOffset,  double offset,  double viewport);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionAnimation GetScrollAnimation( global::Microsoft.UI.Xaml.Controls.ScrollInfo info,  global::System.Numerics.Vector2 currentPosition,  global::Microsoft.UI.Composition.CompositionAnimation defaultAnimation);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void OnScrollCompleted( global::Microsoft.UI.Xaml.Controls.ScrollInfo info);
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollToRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollToRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollByRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollByRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollFromRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollFromRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionInfoChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionInfoChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, object> InteractionInfoChanged;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, global::Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerInteractionRequestedEventArgs> InteractionRequested;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, global::Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs> ScrollByRequested;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, global::Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollFromRequestedEventArgs> ScrollFromRequested;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, global::Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs> ScrollToRequested;
		#endif
	}
}
