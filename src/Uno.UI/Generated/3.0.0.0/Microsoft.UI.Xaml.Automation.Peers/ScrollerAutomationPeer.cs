#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollerAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ScrollerAutomationPeer( global::Microsoft.UI.Xaml.Controls.Primitives.Scroller owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ScrollerAutomationPeer", "ScrollerAutomationPeer.ScrollerAutomationPeer(Scroller owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ScrollerAutomationPeer.ScrollerAutomationPeer(Microsoft.UI.Xaml.Controls.Primitives.Scroller)
	}
}
