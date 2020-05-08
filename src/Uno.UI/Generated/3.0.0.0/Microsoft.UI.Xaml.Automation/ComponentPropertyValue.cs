#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ComponentPropertyValue : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string ElementId
		{
			get
			{
				return (string)this.GetValue(ElementIdProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Site
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(SiteProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ElementIdProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ElementId), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Automation.ComponentPropertyValue), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SiteProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Site), typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Automation.ComponentPropertyValue), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ComponentPropertyValue( global::Microsoft.UI.Xaml.UIElement site,  string elementId) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.ComponentPropertyValue", "ComponentPropertyValue.ComponentPropertyValue(UIElement site, string elementId)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.ComponentPropertyValue.ComponentPropertyValue(Microsoft.UI.Xaml.UIElement, string)
		// Forced skipping of method Microsoft.UI.Xaml.Automation.ComponentPropertyValue.ElementId.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.ComponentPropertyValue.Site.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.ComponentPropertyValue.ElementIdProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.ComponentPropertyValue.SiteProperty.get
	}
}
