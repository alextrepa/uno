#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FocusedElementRemovedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject NewFocusedElement
		{
			get
			{
				throw new global::System.NotImplementedException("The member DependencyObject FocusedElementRemovedEventArgs.NewFocusedElement is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.FocusedElementRemovedEventArgs", "DependencyObject FocusedElementRemovedEventArgs.NewFocusedElement");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject OldFocusedElement
		{
			get
			{
				throw new global::System.NotImplementedException("The member DependencyObject FocusedElementRemovedEventArgs.OldFocusedElement is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusedElementRemovedEventArgs.OldFocusedElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusedElementRemovedEventArgs.NewFocusedElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.FocusedElementRemovedEventArgs.NewFocusedElement.set
	}
}
