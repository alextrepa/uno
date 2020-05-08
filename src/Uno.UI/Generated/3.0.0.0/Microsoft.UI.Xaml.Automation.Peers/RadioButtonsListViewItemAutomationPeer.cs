#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RadioButtonsListViewItemAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.ListViewItemAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RadioButtonsListViewItemAutomationPeer( global::Microsoft.UI.Xaml.Controls.Primitives.RadioButtonsListViewItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.RadioButtonsListViewItemAutomationPeer", "RadioButtonsListViewItemAutomationPeer.RadioButtonsListViewItemAutomationPeer(RadioButtonsListViewItem owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.RadioButtonsListViewItemAutomationPeer.RadioButtonsListViewItemAutomationPeer(Microsoft.UI.Xaml.Controls.Primitives.RadioButtonsListViewItem)
	}
}
