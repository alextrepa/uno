#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Interop
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface INotifyCollectionChanged 
	{
		// Forced skipping of method Microsoft.UI.Xaml.Interop.INotifyCollectionChanged.CollectionChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Interop.INotifyCollectionChanged.CollectionChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		 event global::Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventHandler CollectionChanged;
		#endif
	}
}
