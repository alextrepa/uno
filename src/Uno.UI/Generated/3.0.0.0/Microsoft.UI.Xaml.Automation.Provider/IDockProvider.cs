#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IDockProvider 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.DockPosition DockPosition
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Provider.IDockProvider.DockPosition.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetDockPosition( global::Microsoft.UI.Xaml.Automation.DockPosition dockPosition);
		#endif
	}
}