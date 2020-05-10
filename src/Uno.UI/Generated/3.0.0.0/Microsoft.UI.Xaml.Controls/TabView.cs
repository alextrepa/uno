#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabView : global::Microsoft.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.TabViewWidthMode TabWidthMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.TabViewWidthMode)this.GetValue(TabWidthModeProperty);
			}
			set
			{
				this.SetValue(TabWidthModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DataTemplate TabStripHeaderTemplate
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DataTemplate)this.GetValue(TabStripHeaderTemplateProperty);
			}
			set
			{
				this.SetValue(TabStripHeaderTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object TabStripHeader
		{
			get
			{
				return (object)this.GetValue(TabStripHeaderProperty);
			}
			set
			{
				this.SetValue(TabStripHeaderProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DataTemplate TabStripFooterTemplate
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DataTemplate)this.GetValue(TabStripFooterTemplateProperty);
			}
			set
			{
				this.SetValue(TabStripFooterTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object TabStripFooter
		{
			get
			{
				return (object)this.GetValue(TabStripFooterProperty);
			}
			set
			{
				this.SetValue(TabStripFooterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object TabItemsSource
		{
			get
			{
				return (object)this.GetValue(TabItemsSourceProperty);
			}
			set
			{
				this.SetValue(TabItemsSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.DataTemplateSelector TabItemTemplateSelector
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.DataTemplateSelector)this.GetValue(TabItemTemplateSelectorProperty);
			}
			set
			{
				this.SetValue(TabItemTemplateSelectorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DataTemplate TabItemTemplate
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DataTemplate)this.GetValue(TabItemTemplateProperty);
			}
			set
			{
				this.SetValue(TabItemTemplateProperty, value);
			}
		}
		#endif
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
		public  bool IsAddTabButtonVisible
		{
			get
			{
				return (bool)this.GetValue(IsAddTabButtonVisibleProperty);
			}
			set
			{
				this.SetValue(IsAddTabButtonVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanReorderTabs
		{
			get
			{
				return (bool)this.GetValue(CanReorderTabsProperty);
			}
			set
			{
				this.SetValue(CanReorderTabsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanDragTabs
		{
			get
			{
				return (bool)this.GetValue(CanDragTabsProperty);
			}
			set
			{
				this.SetValue(CanDragTabsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AllowDropTabs
		{
			get
			{
				return (bool)this.GetValue(AllowDropTabsProperty);
			}
			set
			{
				this.SetValue(AllowDropTabsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object AddTabButtonCommandParameter
		{
			get
			{
				return (object)this.GetValue(AddTabButtonCommandParameterProperty);
			}
			set
			{
				this.SetValue(AddTabButtonCommandParameterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Windows.Input.ICommand AddTabButtonCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)this.GetValue(AddTabButtonCommandProperty);
			}
			set
			{
				this.SetValue(AddTabButtonCommandProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<object> TabItems
		{
			get
			{
				return (global::System.Collections.Generic.IList<object>)this.GetValue(TabItemsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AddTabButtonCommandParameterProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AddTabButtonCommandParameter), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AddTabButtonCommandProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AddTabButtonCommand), typeof(global::System.Windows.Input.ICommand), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(global::System.Windows.Input.ICommand)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AllowDropTabsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AllowDropTabs), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanDragTabsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanDragTabs), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanReorderTabsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanReorderTabs), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsAddTabButtonVisibleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsAddTabButtonVisible), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectedIndexProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectedIndex), typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectedItemProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectedItem), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabItemTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabItemTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabItemTemplateSelectorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabItemTemplateSelector), typeof(global::Microsoft.UI.Xaml.Controls.DataTemplateSelector), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.DataTemplateSelector)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabItemsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabItems), typeof(global::System.Collections.Generic.IList<object>), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<object>)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabItemsSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabItemsSource), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabStripFooterProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabStripFooter), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabStripFooterTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabStripFooterTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabStripHeaderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabStripHeader), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabStripHeaderTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabStripHeaderTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabWidthModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabWidthMode), typeof(global::Microsoft.UI.Xaml.Controls.TabViewWidthMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.TabViewWidthMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TabView() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "TabView.TabView()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabView()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabWidthMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabWidthMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripHeader.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripHeader.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripHeaderTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripHeaderTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripFooter.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripFooter.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripFooterTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripFooterTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.IsAddTabButtonVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.IsAddTabButtonVisible.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AddTabButtonCommand.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AddTabButtonCommand.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AddTabButtonCommandParameter.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AddTabButtonCommandParameter.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabCloseRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabCloseRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabDroppedOutside.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabDroppedOutside.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AddTabButtonClick.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AddTabButtonClick.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemsSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemsSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItems.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemTemplateSelector.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemTemplateSelector.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.CanDragTabs.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.CanDragTabs.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.CanReorderTabs.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.CanReorderTabs.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AllowDropTabs.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AllowDropTabs.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.SelectedIndex.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.SelectedIndex.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.SelectedItem.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.SelectedItem.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ContainerFromItem( object item)
		{
			throw new global::System.NotImplementedException("The member DependencyObject TabView.ContainerFromItem(object item) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ContainerFromIndex( int index)
		{
			throw new global::System.NotImplementedException("The member DependencyObject TabView.ContainerFromIndex(int index) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.SelectionChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.SelectionChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabDragStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabDragStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabDragCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabDragCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripDragOver.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripDragOver.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripDrop.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripDrop.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabWidthModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripHeaderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripHeaderTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripFooterProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabStripFooterTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.IsAddTabButtonVisibleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AddTabButtonCommandProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AddTabButtonCommandParameterProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemsSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.TabItemTemplateSelectorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.CanDragTabsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.CanReorderTabsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.AllowDropTabsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.SelectedIndexProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabView.SelectedItemProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TabView, object> AddTabButtonClick
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, object> TabView.AddTabButtonClick");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, object> TabView.AddTabButtonClick");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Controls.SelectionChangedEventHandler SelectionChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event SelectionChangedEventHandler TabView.SelectionChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event SelectionChangedEventHandler TabView.SelectionChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TabView, global::Microsoft.UI.Xaml.Controls.TabViewTabCloseRequestedEventArgs> TabCloseRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, TabViewTabCloseRequestedEventArgs> TabView.TabCloseRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, TabViewTabCloseRequestedEventArgs> TabView.TabCloseRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TabView, global::Microsoft.UI.Xaml.Controls.TabViewTabDragCompletedEventArgs> TabDragCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, TabViewTabDragCompletedEventArgs> TabView.TabDragCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, TabViewTabDragCompletedEventArgs> TabView.TabDragCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TabView, global::Microsoft.UI.Xaml.Controls.TabViewTabDragStartingEventArgs> TabDragStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, TabViewTabDragStartingEventArgs> TabView.TabDragStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, TabViewTabDragStartingEventArgs> TabView.TabDragStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TabView, global::Microsoft.UI.Xaml.Controls.TabViewTabDroppedOutsideEventArgs> TabDroppedOutside
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, TabViewTabDroppedOutsideEventArgs> TabView.TabDroppedOutside");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, TabViewTabDroppedOutsideEventArgs> TabView.TabDroppedOutside");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TabView, global::Windows.Foundation.Collections.IVectorChangedEventArgs> TabItemsChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, IVectorChangedEventArgs> TabView.TabItemsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event TypedEventHandler<TabView, IVectorChangedEventArgs> TabView.TabItemsChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.DragEventHandler TabStripDragOver
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event DragEventHandler TabView.TabStripDragOver");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event DragEventHandler TabView.TabStripDragOver");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.DragEventHandler TabStripDrop
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event DragEventHandler TabView.TabStripDrop");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TabView", "event DragEventHandler TabView.TabStripDrop");
			}
		}
		#endif
	}
}
