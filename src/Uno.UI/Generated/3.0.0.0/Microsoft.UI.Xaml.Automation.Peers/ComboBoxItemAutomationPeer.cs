#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ComboBoxItemAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ComboBoxItemAutomationPeer( global::Microsoft.UI.Xaml.Controls.ComboBoxItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ComboBoxItemAutomationPeer", "ComboBoxItemAutomationPeer.ComboBoxItemAutomationPeer(ComboBoxItem owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ComboBoxItemAutomationPeer.ComboBoxItemAutomationPeer(Microsoft.UI.Xaml.Controls.ComboBoxItem)
	}
}