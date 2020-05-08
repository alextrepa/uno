#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VirtualizingLayout : global::Microsoft.UI.Xaml.Controls.Layout
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public VirtualizingLayout() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.VirtualizingLayout", "VirtualizingLayout.VirtualizingLayout()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.VirtualizingLayout.VirtualizingLayout()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void InitializeForContextCore( global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.VirtualizingLayout", "void VirtualizingLayout.InitializeForContextCore(VirtualizingLayoutContext context)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void UninitializeForContextCore( global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.VirtualizingLayout", "void VirtualizingLayout.UninitializeForContextCore(VirtualizingLayoutContext context)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.Foundation.Size MeasureOverride( global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context,  global::Windows.Foundation.Size availableSize)
		{
			throw new global::System.NotImplementedException("The member Size VirtualizingLayout.MeasureOverride(VirtualizingLayoutContext context, Size availableSize) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.Foundation.Size ArrangeOverride( global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context,  global::Windows.Foundation.Size finalSize)
		{
			throw new global::System.NotImplementedException("The member Size VirtualizingLayout.ArrangeOverride(VirtualizingLayoutContext context, Size finalSize) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnItemsChangedCore( global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context,  object source,  global::Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.VirtualizingLayout", "void VirtualizingLayout.OnItemsChangedCore(VirtualizingLayoutContext context, object source, NotifyCollectionChangedEventArgs args)");
		}
		#endif
	}
}
