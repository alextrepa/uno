#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AutoSuggestBoxAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IInvokeProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AutoSuggestBoxAutomationPeer( global::Microsoft.UI.Xaml.Controls.AutoSuggestBox owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer", "AutoSuggestBoxAutomationPeer.AutoSuggestBoxAutomationPeer(AutoSuggestBox owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer.AutoSuggestBoxAutomationPeer(Microsoft.UI.Xaml.Controls.AutoSuggestBox)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Invoke()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer", "void AutoSuggestBoxAutomationPeer.Invoke()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IInvokeProvider
	}
}