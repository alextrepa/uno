#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewTabDragStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TabViewTabDragStartingEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabViewTabDragStartingEventArgs", "bool TabViewTabDragStartingEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.DataTransfer.DataPackage Data
		{
			get
			{
				throw new global::System.NotImplementedException("The member DataPackage TabViewTabDragStartingEventArgs.Data is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Item
		{
			get
			{
				throw new global::System.NotImplementedException("The member object TabViewTabDragStartingEventArgs.Item is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.TabViewItem Tab
		{
			get
			{
				throw new global::System.NotImplementedException("The member TabViewItem TabViewTabDragStartingEventArgs.Tab is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabDragStartingEventArgs.Cancel.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabDragStartingEventArgs.Cancel.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabDragStartingEventArgs.Data.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabDragStartingEventArgs.Item.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabDragStartingEventArgs.Tab.get
	}
}
