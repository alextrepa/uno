#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollControllerScrollByRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo Info
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollInfo ScrollControllerScrollByRequestedEventArgs.Info is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs", "ScrollInfo ScrollControllerScrollByRequestedEventArgs.Info");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OffsetDelta
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollControllerScrollByRequestedEventArgs.OffsetDelta is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollOptions Options
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollOptions ScrollControllerScrollByRequestedEventArgs.Options is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ScrollControllerScrollByRequestedEventArgs( double offsetDelta,  global::Microsoft.UI.Xaml.Controls.ScrollOptions options) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs", "ScrollControllerScrollByRequestedEventArgs.ScrollControllerScrollByRequestedEventArgs(double offsetDelta, ScrollOptions options)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.ScrollControllerScrollByRequestedEventArgs(double, Microsoft.UI.Xaml.Controls.ScrollOptions)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.OffsetDelta.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.Options.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.Info.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.Info.set
	}
}
