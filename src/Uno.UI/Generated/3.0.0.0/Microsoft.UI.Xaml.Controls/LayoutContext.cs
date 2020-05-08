#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LayoutContext : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object LayoutState
		{
			get
			{
				throw new global::System.NotImplementedException("The member object LayoutContext.LayoutState is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.LayoutContext", "object LayoutContext.LayoutState");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object LayoutStateCore
		{
			get
			{
				throw new global::System.NotImplementedException("The member object LayoutContext.LayoutStateCore is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.LayoutContext", "object LayoutContext.LayoutStateCore");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutContext.LayoutState.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutContext.LayoutState.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutContext.LayoutStateCore.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutContext.LayoutStateCore.set
	}
}
