#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Hosting
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlSourceFocusNavigationRequest 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Guid CorrelationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid XamlSourceFocusNavigationRequest.CorrelationId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Rect HintRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect XamlSourceFocusNavigationRequest.HintRect is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member XamlSourceFocusNavigationReason XamlSourceFocusNavigationRequest.Reason is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public XamlSourceFocusNavigationRequest( global::Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason reason) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest", "XamlSourceFocusNavigationRequest.XamlSourceFocusNavigationRequest(XamlSourceFocusNavigationReason reason)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.XamlSourceFocusNavigationRequest(Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public XamlSourceFocusNavigationRequest( global::Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason reason,  global::Windows.Foundation.Rect hintRect) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest", "XamlSourceFocusNavigationRequest.XamlSourceFocusNavigationRequest(XamlSourceFocusNavigationReason reason, Rect hintRect)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.XamlSourceFocusNavigationRequest(Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason, Windows.Foundation.Rect)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public XamlSourceFocusNavigationRequest( global::Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason reason,  global::Windows.Foundation.Rect hintRect,  global::System.Guid correlationId) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest", "XamlSourceFocusNavigationRequest.XamlSourceFocusNavigationRequest(XamlSourceFocusNavigationReason reason, Rect hintRect, Guid correlationId)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.XamlSourceFocusNavigationRequest(Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason, Windows.Foundation.Rect, System.Guid)
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.Reason.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.HintRect.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.CorrelationId.get
	}
}
