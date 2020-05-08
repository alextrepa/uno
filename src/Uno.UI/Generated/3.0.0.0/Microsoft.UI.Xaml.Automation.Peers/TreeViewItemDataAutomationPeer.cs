#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeViewItemDataAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.ItemAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpandCollapseState TreeViewItemDataAutomationPeer.ExpandCollapseState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TreeViewItemDataAutomationPeer( object item,  global::Microsoft.UI.Xaml.Automation.Peers.TreeViewListAutomationPeer parent) : base(item, parent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.TreeViewItemDataAutomationPeer", "TreeViewItemDataAutomationPeer.TreeViewItemDataAutomationPeer(object item, TreeViewListAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.TreeViewItemDataAutomationPeer.TreeViewItemDataAutomationPeer(object, Microsoft.UI.Xaml.Automation.Peers.TreeViewListAutomationPeer)
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.TreeViewItemDataAutomationPeer.ExpandCollapseState.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Collapse()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.TreeViewItemDataAutomationPeer", "void TreeViewItemDataAutomationPeer.Collapse()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Expand()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.TreeViewItemDataAutomationPeer", "void TreeViewItemDataAutomationPeer.Expand()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider
	}
}
