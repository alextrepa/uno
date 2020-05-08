#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebView2NavigationCompletedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsSuccess
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebView2NavigationCompletedEventArgs.IsSuccess is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Web.WebErrorStatus WebErrorStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebErrorStatus WebView2NavigationCompletedEventArgs.WebErrorStatus is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2NavigationCompletedEventArgs.IsSuccess.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2NavigationCompletedEventArgs.WebErrorStatus.get
	}
}
