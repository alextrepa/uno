#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RepeaterAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RepeaterAutomationPeer( global::Microsoft.UI.Xaml.Controls.ItemsRepeater owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.RepeaterAutomationPeer", "RepeaterAutomationPeer.RepeaterAutomationPeer(ItemsRepeater owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.RepeaterAutomationPeer.RepeaterAutomationPeer(Microsoft.UI.Xaml.Controls.ItemsRepeater)
	}
}
