#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface FrameworkElementAutomationPeerPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Automation.Peers.AutomationPeer> GetAutomationPeersForChildrenOfElement( global::Microsoft.UI.Xaml.UIElement element);
		#endif
	}
}
