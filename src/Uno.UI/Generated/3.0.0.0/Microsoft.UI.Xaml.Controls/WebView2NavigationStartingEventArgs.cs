#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebView2NavigationStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebView2NavigationStartingEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2NavigationStartingEventArgs", "bool WebView2NavigationStartingEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsRedirected
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebView2NavigationStartingEventArgs.IsRedirected is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsUserInitiated
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebView2NavigationStartingEventArgs.IsUserInitiated is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebView2NavigationStartingEventArgs.Uri is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2NavigationStartingEventArgs.Uri.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2NavigationStartingEventArgs.IsUserInitiated.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2NavigationStartingEventArgs.IsRedirected.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2NavigationStartingEventArgs.Cancel.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2NavigationStartingEventArgs.Cancel.set
	}
}
