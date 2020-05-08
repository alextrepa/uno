#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebView2WebMessageReceivedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebView2WebMessageReceivedEventArgs.Source is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string WebMessageAsJson
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebView2WebMessageReceivedEventArgs.WebMessageAsJson is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string WebMessageAsString
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebView2WebMessageReceivedEventArgs.WebMessageAsString is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2WebMessageReceivedEventArgs.Source.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2WebMessageReceivedEventArgs.WebMessageAsJson.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2WebMessageReceivedEventArgs.WebMessageAsString.get
	}
}
