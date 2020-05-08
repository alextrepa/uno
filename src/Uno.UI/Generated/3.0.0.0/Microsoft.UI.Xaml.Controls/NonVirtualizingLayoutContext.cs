#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NonVirtualizingLayoutContext : global::Microsoft.UI.Xaml.Controls.LayoutContext
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Microsoft.UI.Xaml.UIElement> Children
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<UIElement> NonVirtualizingLayoutContext.Children is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Microsoft.UI.Xaml.UIElement> ChildrenCore
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<UIElement> NonVirtualizingLayoutContext.ChildrenCore is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public NonVirtualizingLayoutContext() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext", "NonVirtualizingLayoutContext.NonVirtualizingLayoutContext()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext.NonVirtualizingLayoutContext()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext.Children.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext.ChildrenCore.get
	}
}
