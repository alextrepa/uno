#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewListView : global::Microsoft.UI.Xaml.Controls.ListView
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TabViewListView() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.TabViewListView", "TabViewListView.TabViewListView()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.TabViewListView.TabViewListView()
	}
}
