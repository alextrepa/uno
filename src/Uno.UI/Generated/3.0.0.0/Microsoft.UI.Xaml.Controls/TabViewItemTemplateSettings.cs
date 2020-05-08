#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewItemTemplateSettings : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.IconElement IconElement
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.IconElement)this.GetValue(IconElementProperty);
			}
			set
			{
				this.SetValue(IconElementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IconElementProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IconElement), typeof(global::Microsoft.UI.Xaml.Controls.IconElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.IconElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public TabViewItemTemplateSettings() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings", "TabViewItemTemplateSettings.TabViewItemTemplateSettings()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.TabViewItemTemplateSettings()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.IconElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.IconElement.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.IconElementProperty.get
	}
}
