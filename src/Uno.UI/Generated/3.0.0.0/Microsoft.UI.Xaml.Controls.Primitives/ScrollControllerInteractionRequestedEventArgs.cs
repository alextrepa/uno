#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollControllerInteractionRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ScrollControllerInteractionRequestedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerInteractionRequestedEventArgs", "bool ScrollControllerInteractionRequestedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.PointerPoint PointerPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member PointerPoint ScrollControllerInteractionRequestedEventArgs.PointerPoint is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ScrollControllerInteractionRequestedEventArgs( global::Windows.UI.Input.PointerPoint pointerPoint) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerInteractionRequestedEventArgs", "ScrollControllerInteractionRequestedEventArgs.ScrollControllerInteractionRequestedEventArgs(PointerPoint pointerPoint)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerInteractionRequestedEventArgs.ScrollControllerInteractionRequestedEventArgs(Windows.UI.Input.PointerPoint)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerInteractionRequestedEventArgs.PointerPoint.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerInteractionRequestedEventArgs.Handled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerInteractionRequestedEventArgs.Handled.set
	}
}
