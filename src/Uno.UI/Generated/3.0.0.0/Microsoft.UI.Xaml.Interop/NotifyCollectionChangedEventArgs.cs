#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Interop
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NotifyCollectionChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Specialized.NotifyCollectionChangedAction Action
		{
			get
			{
				throw new global::System.NotImplementedException("The member NotifyCollectionChangedAction NotifyCollectionChangedEventArgs.Action is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Interop.IBindableVector NewItems
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBindableVector NotifyCollectionChangedEventArgs.NewItems is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int NewStartingIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member int NotifyCollectionChangedEventArgs.NewStartingIndex is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Interop.IBindableVector OldItems
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBindableVector NotifyCollectionChangedEventArgs.OldItems is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int OldStartingIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member int NotifyCollectionChangedEventArgs.OldStartingIndex is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public NotifyCollectionChangedEventArgs( global::System.Collections.Specialized.NotifyCollectionChangedAction action,  global::Microsoft.UI.Xaml.Interop.IBindableVector newItems,  global::Microsoft.UI.Xaml.Interop.IBindableVector oldItems,  int newIndex,  int oldIndex) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs", "NotifyCollectionChangedEventArgs.NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IBindableVector newItems, IBindableVector oldItems, int newIndex, int oldIndex)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction, Microsoft.UI.Xaml.Interop.IBindableVector, Microsoft.UI.Xaml.Interop.IBindableVector, int, int)
		// Forced skipping of method Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.Action.get
		// Forced skipping of method Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.NewItems.get
		// Forced skipping of method Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.OldItems.get
		// Forced skipping of method Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.NewStartingIndex.get
		// Forced skipping of method Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.OldStartingIndex.get
	}
}
