#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RadioMenuFlyoutItem : global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsChecked
		{
			get
			{
				return (bool)this.GetValue(IsCheckedProperty);
			}
			set
			{
				this.SetValue(IsCheckedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string GroupName
		{
			get
			{
				return (string)this.GetValue(GroupNameProperty);
			}
			set
			{
				this.SetValue(GroupNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty GroupNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(GroupName), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsCheckedProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsChecked), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RadioMenuFlyoutItem() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem", "RadioMenuFlyoutItem.RadioMenuFlyoutItem()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.RadioMenuFlyoutItem()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.IsChecked.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.IsChecked.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.GroupName.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.GroupName.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.IsCheckedProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.GroupNameProperty.get
	}
}
