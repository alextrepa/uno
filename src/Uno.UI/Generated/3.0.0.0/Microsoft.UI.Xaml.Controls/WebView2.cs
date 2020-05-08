#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebView2 : global::Microsoft.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Uri UriSource
		{
			get
			{
				return (global::System.Uri)this.GetValue(UriSourceProperty);
			}
			set
			{
				this.SetValue(UriSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanGoForward
		{
			get
			{
				return (bool)this.GetValue(CanGoForwardProperty);
			}
			set
			{
				this.SetValue(CanGoForwardProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanGoBack
		{
			get
			{
				return (bool)this.GetValue(CanGoBackProperty);
			}
			set
			{
				this.SetValue(CanGoBackProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanGoBackProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanGoBack), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.WebView2), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanGoForwardProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanGoForward), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.WebView2), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty UriSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(UriSource), typeof(global::System.Uri), 
			typeof(global::Microsoft.UI.Xaml.Controls.WebView2), 
			new FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public WebView2() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "WebView2.WebView2()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.WebView2()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<string> ExecuteScriptAsync( string javascriptCode)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> WebView2.ExecuteScriptAsync(string javascriptCode) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.UriSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.UriSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoForward.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoForward.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoBack.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoBack.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Reload()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.Reload()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void GoForward()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.GoForward()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void GoBack()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.GoBack()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void NavigateToString( string htmlContent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.NavigateToString(string htmlContent)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.NavigationCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.NavigationCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.WebMessageReceived.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.WebMessageReceived.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.NavigationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.NavigationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.UriSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoForwardProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoBackProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.WebView2, global::Microsoft.UI.Xaml.Controls.WebView2NavigationCompletedEventArgs> NavigationCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, WebView2NavigationCompletedEventArgs> WebView2.NavigationCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, WebView2NavigationCompletedEventArgs> WebView2.NavigationCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.WebView2, global::Microsoft.UI.Xaml.Controls.WebView2NavigationStartingEventArgs> NavigationStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, WebView2NavigationStartingEventArgs> WebView2.NavigationStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, WebView2NavigationStartingEventArgs> WebView2.NavigationStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.WebView2, global::Microsoft.UI.Xaml.Controls.WebView2WebMessageReceivedEventArgs> WebMessageReceived
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, WebView2WebMessageReceivedEventArgs> WebView2.WebMessageReceived");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, WebView2WebMessageReceivedEventArgs> WebView2.WebMessageReceived");
			}
		}
		#endif
	}
}
