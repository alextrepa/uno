#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewTabCloseRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Item
		{
			get
			{
				throw new global::System.NotImplementedException("The member object TabViewTabCloseRequestedEventArgs.Item is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.TabViewItem Tab
		{
			get
			{
				throw new global::System.NotImplementedException("The member TabViewItem TabViewTabCloseRequestedEventArgs.Tab is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabCloseRequestedEventArgs.Item.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewTabCloseRequestedEventArgs.Tab.get
	}
}