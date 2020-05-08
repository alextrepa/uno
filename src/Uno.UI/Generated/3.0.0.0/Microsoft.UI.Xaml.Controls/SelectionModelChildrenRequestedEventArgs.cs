#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SelectionModelChildrenRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Children
		{
			get
			{
				throw new global::System.NotImplementedException("The member object SelectionModelChildrenRequestedEventArgs.Children is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SelectionModelChildrenRequestedEventArgs", "object SelectionModelChildrenRequestedEventArgs.Children");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member object SelectionModelChildrenRequestedEventArgs.Source is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SelectionModelChildrenRequestedEventArgs.Source.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SelectionModelChildrenRequestedEventArgs.Children.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SelectionModelChildrenRequestedEventArgs.Children.set
	}
}
