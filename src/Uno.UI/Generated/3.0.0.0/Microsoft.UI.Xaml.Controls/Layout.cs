#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Layout : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InitializeForContext( global::Microsoft.UI.Xaml.Controls.LayoutContext context)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Layout", "void Layout.InitializeForContext(LayoutContext context)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void UninitializeForContext( global::Microsoft.UI.Xaml.Controls.LayoutContext context)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Layout", "void Layout.UninitializeForContext(LayoutContext context)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Size Measure( global::Microsoft.UI.Xaml.Controls.LayoutContext context,  global::Windows.Foundation.Size availableSize)
		{
			throw new global::System.NotImplementedException("The member Size Layout.Measure(LayoutContext context, Size availableSize) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Size Arrange( global::Microsoft.UI.Xaml.Controls.LayoutContext context,  global::Windows.Foundation.Size finalSize)
		{
			throw new global::System.NotImplementedException("The member Size Layout.Arrange(LayoutContext context, Size finalSize) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Layout.MeasureInvalidated.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Layout.MeasureInvalidated.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Layout.ArrangeInvalidated.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Layout.ArrangeInvalidated.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected  void InvalidateMeasure()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Layout", "void Layout.InvalidateMeasure()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected  void InvalidateArrange()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Layout", "void Layout.InvalidateArrange()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Layout, object> ArrangeInvalidated
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Layout", "event TypedEventHandler<Layout, object> Layout.ArrangeInvalidated");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Layout", "event TypedEventHandler<Layout, object> Layout.ArrangeInvalidated");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Layout, object> MeasureInvalidated
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Layout", "event TypedEventHandler<Layout, object> Layout.MeasureInvalidated");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Layout", "event TypedEventHandler<Layout, object> Layout.MeasureInvalidated");
			}
		}
		#endif
	}
}
