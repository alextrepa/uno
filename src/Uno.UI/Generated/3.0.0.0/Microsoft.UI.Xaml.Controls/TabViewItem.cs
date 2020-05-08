#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewItem : global::Microsoft.UI.Xaml.Controls.ListViewItem
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsClosable
		{
			get
			{
				return (bool)this.GetValue(IsClosableProperty);
			}
			set
			{
				this.SetValue(IsClosableProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.IconSource IconSource
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.IconSource)this.GetValue(IconSourceProperty);
			}
			set
			{
				this.SetValue(IconSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DataTemplate HeaderTemplate
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DataTemplate)this.GetValue(HeaderTemplateProperty);
			}
			set
			{
				this.SetValue(HeaderTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Header
		{
			get
			{
				return (object)this.GetValue(HeaderProperty);
			}
			set
			{
				this.SetValue(HeaderProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings TabViewTemplateSettings
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings)this.GetValue(TabViewTemplateSettingsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HeaderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Header), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabViewItem), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HeaderTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HeaderTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabViewItem), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IconSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IconSource), typeof(global::Microsoft.UI.Xaml.Controls.IconSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabViewItem), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.IconSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsClosableProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsClosable), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabViewItem), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabViewTemplateSettingsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabViewTemplateSettings), typeof(global::Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabViewItem), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TabViewItem() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabViewItem", "TabViewItem.TabViewItem()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.TabViewItem()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.Header.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.Header.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.HeaderTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.HeaderTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.IconSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.IconSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.IsClosable.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.IsClosable.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.TabViewTemplateSettings.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.CloseRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.CloseRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.HeaderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.HeaderTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.IconSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.IsClosableProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItem.TabViewTemplateSettingsProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TabViewItem, global::Microsoft.UI.Xaml.Controls.TabViewTabCloseRequestedEventArgs> CloseRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabViewItem", "event TypedEventHandler<TabViewItem, TabViewTabCloseRequestedEventArgs> TabViewItem.CloseRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabViewItem", "event TypedEventHandler<TabViewItem, TabViewTabCloseRequestedEventArgs> TabViewItem.CloseRequested");
			}
		}
		#endif
	}
}
