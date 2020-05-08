#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Hosting
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlSourceFocusNavigationResult 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool WasFocusMoved
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool XamlSourceFocusNavigationResult.WasFocusMoved is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public XamlSourceFocusNavigationResult( bool focusMoved) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationResult", "XamlSourceFocusNavigationResult.XamlSourceFocusNavigationResult(bool focusMoved)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationResult.XamlSourceFocusNavigationResult(bool)
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationResult.WasFocusMoved.get
	}
}
