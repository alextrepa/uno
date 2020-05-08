#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewItemAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.ListViewItemAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TabViewItemAutomationPeer( global::Microsoft.UI.Xaml.Controls.TabViewItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.TabViewItemAutomationPeer", "TabViewItemAutomationPeer.TabViewItemAutomationPeer(TabViewItem owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.TabViewItemAutomationPeer.TabViewItemAutomationPeer(Microsoft.UI.Xaml.Controls.TabViewItem)
	}
}
