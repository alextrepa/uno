#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeView : global::Microsoft.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.TreeViewSelectionMode SelectionMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.TreeViewSelectionMode)this.GetValue(SelectionModeProperty);
			}
			set
			{
				this.SetValue(SelectionModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Controls.TreeViewNode> RootNodes
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<TreeViewNode> TreeView.RootNodes is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Controls.TreeViewNode> SelectedNodes
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<TreeViewNode> TreeView.SelectedNodes is not implemented in Uno.");
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
		public  global::Microsoft.UI.Xaml.Controls.DataTemplateSelector ItemTemplateSelector
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.DataTemplateSelector)this.GetValue(ItemTemplateSelectorProperty);
			}
			set
			{
				this.SetValue(ItemTemplateSelectorProperty, value);
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
		public  global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection ItemContainerTransitions
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection)this.GetValue(ItemContainerTransitionsProperty);
			}
			set
			{
				this.SetValue(ItemContainerTransitionsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.StyleSelector ItemContainerStyleSelector
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.StyleSelector)this.GetValue(ItemContainerStyleSelectorProperty);
			}
			set
			{
				this.SetValue(ItemContainerStyleSelectorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Style ItemContainerStyle
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Style)this.GetValue(ItemContainerStyleProperty);
			}
			set
			{
				this.SetValue(ItemContainerStyleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanReorderItems
		{
			get
			{
				return (bool)this.GetValue(CanReorderItemsProperty);
			}
			set
			{
				this.SetValue(CanReorderItemsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanDragItems
		{
			get
			{
				return (bool)this.GetValue(CanDragItemsProperty);
			}
			set
			{
				this.SetValue(CanDragItemsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"SelectionMode", typeof(global::Microsoft.UI.Xaml.Controls.TreeViewSelectionMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.TreeViewSelectionMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanDragItemsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"CanDragItems", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanReorderItemsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"CanReorderItems", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemContainerStyleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ItemContainerStyle", typeof(global::Microsoft.UI.Xaml.Style), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Style)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemContainerStyleSelectorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ItemContainerStyleSelector", typeof(global::Microsoft.UI.Xaml.Controls.StyleSelector), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.StyleSelector)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemContainerTransitionsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ItemContainerTransitions", typeof(global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ItemTemplate", typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemTemplateSelectorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ItemTemplateSelector", typeof(global::Microsoft.UI.Xaml.Controls.DataTemplateSelector), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.DataTemplateSelector)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemsSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ItemsSource", typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeView), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TreeView() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "TreeView.TreeView()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.TreeView()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.RootNodes.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.SelectionMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.SelectionMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.SelectedNodes.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Expand( global::Microsoft.UI.Xaml.Controls.TreeViewNode value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "void TreeView.Expand(TreeViewNode value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Collapse( global::Microsoft.UI.Xaml.Controls.TreeViewNode value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "void TreeView.Collapse(TreeViewNode value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SelectAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "void TreeView.SelectAll()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemInvoked.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemInvoked.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.Expanding.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.Expanding.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.Collapsed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.Collapsed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.TreeViewNode NodeFromContainer( global::Microsoft.UI.Xaml.DependencyObject container)
		{
			throw new global::System.NotImplementedException("The member TreeViewNode TreeView.NodeFromContainer(DependencyObject container) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ContainerFromNode( global::Microsoft.UI.Xaml.Controls.TreeViewNode node)
		{
			throw new global::System.NotImplementedException("The member DependencyObject TreeView.ContainerFromNode(TreeViewNode node) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ItemFromContainer( global::Microsoft.UI.Xaml.DependencyObject container)
		{
			throw new global::System.NotImplementedException("The member object TreeView.ItemFromContainer(DependencyObject container) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ContainerFromItem( object item)
		{
			throw new global::System.NotImplementedException("The member DependencyObject TreeView.ContainerFromItem(object item) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.CanDragItems.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.CanDragItems.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.CanReorderItems.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.CanReorderItems.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemTemplateSelector.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemTemplateSelector.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyle.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyleSelector.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyleSelector.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerTransitions.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerTransitions.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemsSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemsSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.DragItemsStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.DragItemsStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.DragItemsCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.DragItemsCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.CanDragItemsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.CanReorderItemsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemTemplateSelectorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyleSelectorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemContainerTransitionsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.ItemsSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeView.SelectionModeProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TreeView, global::Microsoft.UI.Xaml.Controls.TreeViewCollapsedEventArgs> Collapsed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewCollapsedEventArgs> TreeView.Collapsed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewCollapsedEventArgs> TreeView.Collapsed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TreeView, global::Microsoft.UI.Xaml.Controls.TreeViewExpandingEventArgs> Expanding
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewExpandingEventArgs> TreeView.Expanding");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewExpandingEventArgs> TreeView.Expanding");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TreeView, global::Microsoft.UI.Xaml.Controls.TreeViewItemInvokedEventArgs> ItemInvoked
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewItemInvokedEventArgs> TreeView.ItemInvoked");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewItemInvokedEventArgs> TreeView.ItemInvoked");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TreeView, global::Microsoft.UI.Xaml.Controls.TreeViewDragItemsCompletedEventArgs> DragItemsCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewDragItemsCompletedEventArgs> TreeView.DragItemsCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewDragItemsCompletedEventArgs> TreeView.DragItemsCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TreeView, global::Microsoft.UI.Xaml.Controls.TreeViewDragItemsStartingEventArgs> DragItemsStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewDragItemsStartingEventArgs> TreeView.DragItemsStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TreeView", "event TypedEventHandler<TreeView, TreeViewDragItemsStartingEventArgs> TreeView.DragItemsStarting");
			}
		}
		#endif
	}
}