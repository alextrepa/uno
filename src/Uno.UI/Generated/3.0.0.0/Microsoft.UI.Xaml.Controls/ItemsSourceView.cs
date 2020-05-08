#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemsSourceView : global::Microsoft.UI.Xaml.Interop.INotifyCollectionChanged
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int Count
		{
			get
			{
				throw new global::System.NotImplementedException("The member int ItemsSourceView.Count is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool HasKeyIndexMapping
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ItemsSourceView.HasKeyIndexMapping is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ItemsSourceView( object source) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsSourceView", "ItemsSourceView.ItemsSourceView(object source)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsSourceView.ItemsSourceView(object)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsSourceView.Count.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object GetAt( int index)
		{
			throw new global::System.NotImplementedException("The member object ItemsSourceView.GetAt(int index) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsSourceView.HasKeyIndexMapping.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string KeyFromIndex( int index)
		{
			throw new global::System.NotImplementedException("The member string ItemsSourceView.KeyFromIndex(int index) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int IndexFromKey( string key)
		{
			throw new global::System.NotImplementedException("The member int ItemsSourceView.IndexFromKey(string key) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsSourceView.CollectionChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsSourceView.CollectionChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventHandler CollectionChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsSourceView", "event NotifyCollectionChangedEventHandler ItemsSourceView.CollectionChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsSourceView", "event NotifyCollectionChangedEventHandler ItemsSourceView.CollectionChanged");
			}
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Interop.INotifyCollectionChanged
	}
}
