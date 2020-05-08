#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NonVirtualizingLayout : global::Microsoft.UI.Xaml.Controls.Layout
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public NonVirtualizingLayout() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.NonVirtualizingLayout", "NonVirtualizingLayout.NonVirtualizingLayout()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.NonVirtualizingLayout.NonVirtualizingLayout()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void InitializeForContextCore( global::Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext context)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.NonVirtualizingLayout", "void NonVirtualizingLayout.InitializeForContextCore(NonVirtualizingLayoutContext context)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void UninitializeForContextCore( global::Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext context)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.NonVirtualizingLayout", "void NonVirtualizingLayout.UninitializeForContextCore(NonVirtualizingLayoutContext context)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.Foundation.Size MeasureOverride( global::Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext context,  global::Windows.Foundation.Size availableSize)
		{
			throw new global::System.NotImplementedException("The member Size NonVirtualizingLayout.MeasureOverride(NonVirtualizingLayoutContext context, Size availableSize) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.Foundation.Size ArrangeOverride( global::Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext context,  global::Windows.Foundation.Size finalSize)
		{
			throw new global::System.NotImplementedException("The member Size NonVirtualizingLayout.ArrangeOverride(NonVirtualizingLayoutContext context, Size finalSize) is not implemented in Uno.");
		}
		#endif
	}
}
