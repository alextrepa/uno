#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RadioButtons : global::Microsoft.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object SelectedItem
		{
			get
			{
				return (object)this.GetValue(SelectedItemProperty);
			}
			set
			{
				this.SetValue(SelectedItemProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int SelectedIndex
		{
			get
			{
				return (int)this.GetValue(SelectedIndexProperty);
			}
			set
			{
				this.SetValue(SelectedIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MaximumColumns
		{
			get
			{
				return (int)this.GetValue(MaximumColumnsProperty);
			}
			set
			{
				this.SetValue(MaximumColumnsProperty, value);
			}
		}
		#endif
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
		public  global::System.Collections.Generic.IList<object> Items
		{
			get
			{
				return (global::System.Collections.Generic.IList<object>)this.GetValue(ItemsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HeaderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Header), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioButtons), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioButtons), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Items), typeof(global::System.Collections.Generic.IList<object>), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioButtons), 
			new FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<object>)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemsSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemsSource), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioButtons), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MaximumColumnsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MaximumColumns), typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioButtons), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectedIndexProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectedIndex), typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioButtons), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectedItemProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectedItem), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.RadioButtons), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RadioButtons() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RadioButtons", "RadioButtons.RadioButtons()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.RadioButtons()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.ItemsSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.ItemsSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.Items.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.ItemTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.ItemTemplate.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ContainerFromItem( object item)
		{
			throw new global::System.NotImplementedException("The member DependencyObject RadioButtons.ContainerFromItem(object item) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ContainerFromIndex( int index)
		{
			throw new global::System.NotImplementedException("The member DependencyObject RadioButtons.ContainerFromIndex(int index) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.SelectedIndex.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.SelectedIndex.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.SelectedItem.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.SelectedItem.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.SelectionChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.SelectionChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.MaximumColumns.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.MaximumColumns.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.Header.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.Header.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.ItemsSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.ItemsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.ItemTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.SelectedIndexProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.SelectedItemProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.MaximumColumnsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioButtons.HeaderProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Controls.SelectionChangedEventHandler SelectionChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RadioButtons", "event SelectionChangedEventHandler RadioButtons.SelectionChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RadioButtons", "event SelectionChangedEventHandler RadioButtons.SelectionChanged");
			}
		}
		#endif
	}
}
