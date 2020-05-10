#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Input
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class FocusManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static object GetFocusedElement( global::Microsoft.UI.Xaml.XamlRoot xamlRoot)
		{
			throw new global::System.NotImplementedException("The member object FocusManager.GetFocusedElement(XamlRoot xamlRoot) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusManager.GotFocus.add
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusManager.GotFocus.remove
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusManager.LostFocus.add
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusManager.LostFocus.remove
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusManager.GettingFocus.add
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusManager.GettingFocus.remove
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusManager.LosingFocus.add
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusManager.LosingFocus.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Microsoft.UI.Xaml.Input.FocusMovementResult> TryFocusAsync( global::Microsoft.UI.Xaml.DependencyObject element,  global::Microsoft.UI.Xaml.FocusState value)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<FocusMovementResult> FocusManager.TryFocusAsync(DependencyObject element, FocusState value) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Microsoft.UI.Xaml.Input.FocusMovementResult> TryMoveFocusAsync( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<FocusMovementResult> FocusManager.TryMoveFocusAsync(FocusNavigationDirection focusNavigationDirection) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Microsoft.UI.Xaml.Input.FocusMovementResult> TryMoveFocusAsync( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection,  global::Microsoft.UI.Xaml.Input.FindNextElementOptions focusNavigationOptions)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<FocusMovementResult> FocusManager.TryMoveFocusAsync(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool TryMoveFocus( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection,  global::Microsoft.UI.Xaml.Input.FindNextElementOptions focusNavigationOptions)
		{
			throw new global::System.NotImplementedException("The member bool FocusManager.TryMoveFocus(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyObject FindNextElement( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection)
		{
			throw new global::System.NotImplementedException("The member DependencyObject FocusManager.FindNextElement(FocusNavigationDirection focusNavigationDirection) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Input.FocusManager.FindFirstFocusableElement(Microsoft.UI.Xaml.DependencyObject)
		// Skipping already declared method Microsoft.UI.Xaml.Input.FocusManager.FindLastFocusableElement(Microsoft.UI.Xaml.DependencyObject)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyObject FindNextElement( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection,  global::Microsoft.UI.Xaml.Input.FindNextElementOptions focusNavigationOptions)
		{
			throw new global::System.NotImplementedException("The member DependencyObject FocusManager.FindNextElement(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Input.FocusManager.FindNextFocusableElement(Microsoft.UI.Xaml.Input.FocusNavigationDirection)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.UIElement FindNextFocusableElement( global::Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection,  global::Windows.Foundation.Rect hintRect)
		{
			throw new global::System.NotImplementedException("The member UIElement FocusManager.FindNextFocusableElement(FocusNavigationDirection focusNavigationDirection, Rect hintRect) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Input.FocusManager.TryMoveFocus(Microsoft.UI.Xaml.Input.FocusNavigationDirection)
		// Skipping already declared method Microsoft.UI.Xaml.Input.FocusManager.GetFocusedElement()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static event global::System.EventHandler<global::Microsoft.UI.Xaml.Input.GettingFocusEventArgs> GettingFocus
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.FocusManager", "event EventHandler<GettingFocusEventArgs> FocusManager.GettingFocus");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.FocusManager", "event EventHandler<GettingFocusEventArgs> FocusManager.GettingFocus");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.Input.FocusManager.GotFocus
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static event global::System.EventHandler<global::Microsoft.UI.Xaml.Input.LosingFocusEventArgs> LosingFocus
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.FocusManager", "event EventHandler<LosingFocusEventArgs> FocusManager.LosingFocus");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.FocusManager", "event EventHandler<LosingFocusEventArgs> FocusManager.LosingFocus");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.Input.FocusManager.LostFocus
	}
}
