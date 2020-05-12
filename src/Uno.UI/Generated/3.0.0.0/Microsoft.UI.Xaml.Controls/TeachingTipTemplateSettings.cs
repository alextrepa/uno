#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TeachingTipTemplateSettings : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Thickness TopRightHighlightMargin
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Thickness)this.GetValue(TopRightHighlightMarginProperty);
			}
			set
			{
				this.SetValue(TopRightHighlightMarginProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Thickness TopLeftHighlightMargin
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Thickness)this.GetValue(TopLeftHighlightMarginProperty);
			}
			set
			{
				this.SetValue(TopLeftHighlightMarginProperty, value);
			}
		}
		#endif
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
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.IconElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TopLeftHighlightMarginProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TopLeftHighlightMargin), typeof(global::Microsoft.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TopRightHighlightMarginProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TopRightHighlightMargin), typeof(global::Microsoft.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public TeachingTipTemplateSettings() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings", "TeachingTipTemplateSettings.TeachingTipTemplateSettings()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.TeachingTipTemplateSettings()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.TopRightHighlightMargin.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.TopRightHighlightMargin.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.TopLeftHighlightMargin.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.TopLeftHighlightMargin.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.IconElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.IconElement.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.TopRightHighlightMarginProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.TopLeftHighlightMarginProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings.IconElementProperty.get
	}
}