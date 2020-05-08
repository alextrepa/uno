#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollControllerScrollToRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo Info
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollInfo ScrollControllerScrollToRequestedEventArgs.Info is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs", "ScrollInfo ScrollControllerScrollToRequestedEventArgs.Info");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Offset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollControllerScrollToRequestedEventArgs.Offset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollOptions Options
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollOptions ScrollControllerScrollToRequestedEventArgs.Options is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ScrollControllerScrollToRequestedEventArgs( double offset,  global::Microsoft.UI.Xaml.Controls.ScrollOptions options) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs", "ScrollControllerScrollToRequestedEventArgs.ScrollControllerScrollToRequestedEventArgs(double offset, ScrollOptions options)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.ScrollControllerScrollToRequestedEventArgs(double, Microsoft.UI.Xaml.Controls.ScrollOptions)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.Offset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.Options.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.Info.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.Info.set
	}
}
