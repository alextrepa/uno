#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IUIElementHostingPreviewStaticsPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetComponentSite( global::Microsoft.UI.Xaml.UIElement element,  object componentSite);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetAutomationProperty( global::Microsoft.UI.Xaml.UIElement element,  global::Microsoft.UI.Xaml.Automation.AutomationProperty property,  global::Microsoft.UI.Xaml.Automation.ComponentPropertyValue value);
		#endif
	}
}
