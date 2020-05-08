#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WrapGrid : global::Microsoft.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.VerticalAlignment VerticalChildrenAlignment
		{
			get
			{
				return (global::Microsoft.UI.Xaml.VerticalAlignment)this.GetValue(VerticalChildrenAlignmentProperty);
			}
			set
			{
				this.SetValue(VerticalChildrenAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Orientation Orientation
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Orientation)this.GetValue(OrientationProperty);
			}
			set
			{
				this.SetValue(OrientationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MaximumRowsOrColumns
		{
			get
			{
				return (int)this.GetValue(MaximumRowsOrColumnsProperty);
			}
			set
			{
				this.SetValue(MaximumRowsOrColumnsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ItemWidth
		{
			get
			{
				return (double)this.GetValue(ItemWidthProperty);
			}
			set
			{
				this.SetValue(ItemWidthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ItemHeight
		{
			get
			{
				return (double)this.GetValue(ItemHeightProperty);
			}
			set
			{
				this.SetValue(ItemHeightProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.HorizontalAlignment HorizontalChildrenAlignment
		{
			get
			{
				return (global::Microsoft.UI.Xaml.HorizontalAlignment)this.GetValue(HorizontalChildrenAlignmentProperty);
			}
			set
			{
				this.SetValue(HorizontalChildrenAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalChildrenAlignmentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalChildrenAlignment), typeof(global::Microsoft.UI.Xaml.HorizontalAlignment), 
			typeof(global::Microsoft.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.HorizontalAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemHeightProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemHeight), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemWidthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemWidth), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MaximumRowsOrColumnsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MaximumRowsOrColumns), typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Orientation), typeof(global::Microsoft.UI.Xaml.Controls.Orientation), 
			typeof(global::Microsoft.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Orientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalChildrenAlignmentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalChildrenAlignment), typeof(global::Microsoft.UI.Xaml.VerticalAlignment), 
			typeof(global::Microsoft.UI.Xaml.Controls.WrapGrid), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.VerticalAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public WrapGrid() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WrapGrid", "WrapGrid.WrapGrid()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.WrapGrid()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.ItemWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.ItemWidth.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.ItemHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.ItemHeight.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.Orientation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.Orientation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.HorizontalChildrenAlignment.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.HorizontalChildrenAlignment.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.VerticalChildrenAlignment.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.VerticalChildrenAlignment.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.MaximumRowsOrColumns.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.MaximumRowsOrColumns.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.ItemWidthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.ItemHeightProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.OrientationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.HorizontalChildrenAlignmentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.VerticalChildrenAlignmentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WrapGrid.MaximumRowsOrColumnsProperty.get
	}
}
