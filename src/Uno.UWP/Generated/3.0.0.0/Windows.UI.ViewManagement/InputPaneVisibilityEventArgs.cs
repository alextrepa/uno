#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InputPaneVisibilityEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool EnsuredFocusedElementInView
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool InputPaneVisibilityEventArgs.EnsuredFocusedElementInView is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.InputPaneVisibilityEventArgs", "bool InputPaneVisibilityEventArgs.EnsuredFocusedElementInView");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Rect OccludedRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect InputPaneVisibilityEventArgs.OccludedRect is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.ViewManagement.InputPaneVisibilityEventArgs.OccludedRect.get
		// Forced skipping of method Windows.UI.ViewManagement.InputPaneVisibilityEventArgs.EnsuredFocusedElementInView.set
		// Forced skipping of method Windows.UI.ViewManagement.InputPaneVisibilityEventArgs.EnsuredFocusedElementInView.get
	}
}
