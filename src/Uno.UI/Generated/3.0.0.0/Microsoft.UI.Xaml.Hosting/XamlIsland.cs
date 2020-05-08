#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Hosting
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlIsland : global::Microsoft.UI.Xaml.Controls.Panel
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object MaterialProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member object XamlIsland.MaterialProperties is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlIsland", "object XamlIsland.MaterialProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Content
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement XamlIsland.Content is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlIsland", "UIElement XamlIsland.Content");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object AppContent
		{
			get
			{
				throw new global::System.NotImplementedException("The member object XamlIsland.AppContent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object FocusController
		{
			get
			{
				throw new global::System.NotImplementedException("The member object XamlIsland.FocusController is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public XamlIsland() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlIsland", "XamlIsland.XamlIsland()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlIsland.XamlIsland()
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlIsland.AppContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlIsland.Content.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlIsland.Content.set
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlIsland.FocusController.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlIsland.MaterialProperties.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlIsland.MaterialProperties.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetScreenOffsetOverride( global::Windows.Foundation.Point offsetOnScreen)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlIsland", "void XamlIsland.SetScreenOffsetOverride(Point offsetOnScreen)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetFocus()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlIsland", "void XamlIsland.SetFocus()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Hosting.XamlIsland GetIslandFromElement( global::Microsoft.UI.Xaml.DependencyObject element)
		{
			throw new global::System.NotImplementedException("The member XamlIsland XamlIsland.GetIslandFromElement(DependencyObject element) is not implemented in Uno.");
		}
		#endif
	}
}
