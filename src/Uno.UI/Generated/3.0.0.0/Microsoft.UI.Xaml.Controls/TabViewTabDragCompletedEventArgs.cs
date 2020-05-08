#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewTabDragCompletedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.DataTransfer.DataPackageOperation DropResult
		{
			get
			{
				throw new global::System.NotImplementedException("The member DataPackageOperation TabViewTabDragCompletedEventArgs.DropResult is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Item
		{
			get
			{
				throw new global::System.NotImplementedException("The member object TabViewTabDragCompletedEventArgs.Item is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.TabViewItem Tab
		{
			get
			{
				throw new global::System.NotImplementedException("The member TabViewItem TabViewTabDragCompletedEventArgs.Tab is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabDragCompletedEventArgs.DropResult.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabDragCompletedEventArgs.Item.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabDragCompletedEventArgs.Tab.get
	}
}
