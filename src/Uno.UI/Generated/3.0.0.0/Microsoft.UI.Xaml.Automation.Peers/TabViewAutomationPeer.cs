#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TabViewAutomationPeer( global::Microsoft.UI.Xaml.Controls.TabView owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.TabViewAutomationPeer", "TabViewAutomationPeer.TabViewAutomationPeer(TabView owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.TabViewAutomationPeer.TabViewAutomationPeer(Microsoft.UI.Xaml.Controls.TabView)
	}
}
