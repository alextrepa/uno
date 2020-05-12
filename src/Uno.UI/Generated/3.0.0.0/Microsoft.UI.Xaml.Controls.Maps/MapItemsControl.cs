#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapItemsControl : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ItemsSource
		{
			get
			{
				return (object)this.GetValue(ItemsSourceProperty);
			}
			set
			{
				this.SetValue(ItemsSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DataTemplate ItemTemplate
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DataTemplate)this.GetValue(ItemTemplateProperty);
			}
			set
			{
				this.SetValue(ItemTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.DependencyObject> Items
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.DependencyObject>)this.GetValue(ItemsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ItemTemplate", typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapItemsControl), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Items", typeof(global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.DependencyObject>), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapItemsControl), 
			new FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.DependencyObject>)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemsSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ItemsSource", typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapItemsControl), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.MapItemsControl()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.MapItemsControl()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.ItemsSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.ItemsSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.Items.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.ItemTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.ItemTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.ItemsSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.ItemsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapItemsControl.ItemTemplateProperty.get
	}
}