#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InputPane 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Rect OccludedRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect InputPane.OccludedRect is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Visible
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool InputPane.Visible is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.InputPane", "bool InputPane.Visible");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.ViewManagement.InputPane.Showing.add
		// Forced skipping of method Windows.UI.ViewManagement.InputPane.Showing.remove
		// Forced skipping of method Windows.UI.ViewManagement.InputPane.Hiding.add
		// Forced skipping of method Windows.UI.ViewManagement.InputPane.Hiding.remove
		// Forced skipping of method Windows.UI.ViewManagement.InputPane.OccludedRect.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryShow()
		{
			throw new global::System.NotImplementedException("The member bool InputPane.TryShow() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryHide()
		{
			throw new global::System.NotImplementedException("The member bool InputPane.TryHide() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.ViewManagement.InputPane.Visible.get
		// Forced skipping of method Windows.UI.ViewManagement.InputPane.Visible.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.ViewManagement.InputPane GetForUIContext( global::Windows.UI.UIContext context)
		{
			throw new global::System.NotImplementedException("The member InputPane InputPane.GetForUIContext(UIContext context) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.ViewManagement.InputPane GetForCurrentView()
		{
			throw new global::System.NotImplementedException("The member InputPane InputPane.GetForCurrentView() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.InputPane, global::Windows.UI.ViewManagement.InputPaneVisibilityEventArgs> Hiding
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.InputPane", "event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> InputPane.Hiding");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.InputPane", "event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> InputPane.Hiding");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.InputPane, global::Windows.UI.ViewManagement.InputPaneVisibilityEventArgs> Showing
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.InputPane", "event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> InputPane.Showing");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.InputPane", "event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> InputPane.Showing");
			}
		}
		#endif
	}
}
