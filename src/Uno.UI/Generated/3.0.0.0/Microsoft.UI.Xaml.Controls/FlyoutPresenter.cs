#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class FlyoutPresenter : global::Microsoft.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsDefaultShadowEnabled
		{
			get
			{
				return (bool)this.GetValue(IsDefaultShadowEnabledProperty);
			}
			set
			{
				this.SetValue(IsDefaultShadowEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsDefaultShadowEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsDefaultShadowEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.FlyoutPresenter), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.FlyoutPresenter.FlyoutPresenter()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlyoutPresenter.FlyoutPresenter()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlyoutPresenter.IsDefaultShadowEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlyoutPresenter.IsDefaultShadowEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlyoutPresenter.IsDefaultShadowEnabledProperty.get
	}
}