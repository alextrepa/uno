#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ButtonBaseAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected ButtonBaseAutomationPeer( global::Microsoft.UI.Xaml.Controls.Primitives.ButtonBase owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer", "ButtonBaseAutomationPeer.ButtonBaseAutomationPeer(ButtonBase owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer.ButtonBaseAutomationPeer(Microsoft.UI.Xaml.Controls.Primitives.ButtonBase)
	}
}