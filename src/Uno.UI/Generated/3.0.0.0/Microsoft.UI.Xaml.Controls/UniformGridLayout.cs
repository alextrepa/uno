#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UniformGridLayout : global::Microsoft.UI.Xaml.Controls.VirtualizingLayout
	{
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
		public  double MinRowSpacing
		{
			get
			{
				return (double)this.GetValue(MinRowSpacingProperty);
			}
			set
			{
				this.SetValue(MinRowSpacingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double MinItemWidth
		{
			get
			{
				return (double)this.GetValue(MinItemWidthProperty);
			}
			set
			{
				this.SetValue(MinItemWidthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double MinItemHeight
		{
			get
			{
				return (double)this.GetValue(MinItemHeightProperty);
			}
			set
			{
				this.SetValue(MinItemHeightProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double MinColumnSpacing
		{
			get
			{
				return (double)this.GetValue(MinColumnSpacingProperty);
			}
			set
			{
				this.SetValue(MinColumnSpacingProperty, value);
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
		public  global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch ItemsStretch
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch)this.GetValue(ItemsStretchProperty);
			}
			set
			{
				this.SetValue(ItemsStretchProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsJustification ItemsJustification
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsJustification)this.GetValue(ItemsJustificationProperty);
			}
			set
			{
				this.SetValue(ItemsJustificationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemsJustificationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemsJustification), typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsJustification), 
			typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsJustification)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemsStretchProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemsStretch), typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch), 
			typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MaximumRowsOrColumnsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MaximumRowsOrColumns), typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinColumnSpacingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinColumnSpacing), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinItemHeightProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinItemHeight), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinItemWidthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinItemWidth), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinRowSpacingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinRowSpacing), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Orientation), typeof(global::Microsoft.UI.Xaml.Controls.Orientation), 
			typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Orientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public UniformGridLayout() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.UniformGridLayout", "UniformGridLayout.UniformGridLayout()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.UniformGridLayout()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.Orientation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.Orientation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinItemWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinItemWidth.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinItemHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinItemHeight.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinRowSpacing.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinRowSpacing.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinColumnSpacing.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinColumnSpacing.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.ItemsJustification.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.ItemsJustification.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.ItemsStretch.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.ItemsStretch.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MaximumRowsOrColumns.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MaximumRowsOrColumns.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.OrientationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinItemWidthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinItemHeightProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinRowSpacingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MinColumnSpacingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.ItemsJustificationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.ItemsStretchProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.UniformGridLayout.MaximumRowsOrColumnsProperty.get
	}
}
