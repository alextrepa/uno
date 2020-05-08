#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollerAnchorRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement AnchorElement
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ScrollerAnchorRequestedEventArgs.AnchorElement is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollerAnchorRequestedEventArgs", "UIElement ScrollerAnchorRequestedEventArgs.AnchorElement");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.UIElement> AnchorCandidates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<UIElement> ScrollerAnchorRequestedEventArgs.AnchorCandidates is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerAnchorRequestedEventArgs.AnchorCandidates.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerAnchorRequestedEventArgs.AnchorElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerAnchorRequestedEventArgs.AnchorElement.set
	}
}
