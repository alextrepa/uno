#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FlowLayout : global::Microsoft.UI.Xaml.Controls.VirtualizingLayout
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
		public  global::Microsoft.UI.Xaml.Controls.FlowLayoutLineAlignment LineAlignment
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.FlowLayoutLineAlignment)this.GetValue(LineAlignmentProperty);
			}
			set
			{
				this.SetValue(LineAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LineAlignmentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(LineAlignment), typeof(global::Microsoft.UI.Xaml.Controls.FlowLayoutLineAlignment), 
			typeof(global::Microsoft.UI.Xaml.Controls.FlowLayout), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.FlowLayoutLineAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinColumnSpacingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinColumnSpacing), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.FlowLayout), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinRowSpacingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinRowSpacing), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.FlowLayout), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Orientation), typeof(global::Microsoft.UI.Xaml.Controls.Orientation), 
			typeof(global::Microsoft.UI.Xaml.Controls.FlowLayout), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Orientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public FlowLayout() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.FlowLayout", "FlowLayout.FlowLayout()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.FlowLayout()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.Orientation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.Orientation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.MinRowSpacing.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.MinRowSpacing.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.MinColumnSpacing.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.MinColumnSpacing.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.LineAlignment.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.LineAlignment.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.Foundation.Size GetMeasureSize( int index,  global::Windows.Foundation.Size availableSize)
		{
			throw new global::System.NotImplementedException("The member Size FlowLayout.GetMeasureSize(int index, Size availableSize) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.Foundation.Size GetProvisionalArrangeSize( int index,  global::Windows.Foundation.Size measureSize,  global::Windows.Foundation.Size desiredSize)
		{
			throw new global::System.NotImplementedException("The member Size FlowLayout.GetProvisionalArrangeSize(int index, Size measureSize, Size desiredSize) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual bool ShouldBreakLine( int index,  double remainingSpace)
		{
			throw new global::System.NotImplementedException("The member bool FlowLayout.ShouldBreakLine(int index, double remainingSpace) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Microsoft.UI.Xaml.Controls.FlowLayoutAnchorInfo GetAnchorForRealizationRect( global::Windows.Foundation.Size availableSize,  global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context)
		{
			throw new global::System.NotImplementedException("The member FlowLayoutAnchorInfo FlowLayout.GetAnchorForRealizationRect(Size availableSize, VirtualizingLayoutContext context) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Microsoft.UI.Xaml.Controls.FlowLayoutAnchorInfo GetAnchorForTargetElement( int targetIndex,  global::Windows.Foundation.Size availableSize,  global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context)
		{
			throw new global::System.NotImplementedException("The member FlowLayoutAnchorInfo FlowLayout.GetAnchorForTargetElement(int targetIndex, Size availableSize, VirtualizingLayoutContext context) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.Foundation.Rect GetExtent( global::Windows.Foundation.Size availableSize,  global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context,  global::Microsoft.UI.Xaml.UIElement firstRealized,  int firstRealizedItemIndex,  global::Windows.Foundation.Rect firstRealizedLayoutBounds,  global::Microsoft.UI.Xaml.UIElement lastRealized,  int lastRealizedItemIndex,  global::Windows.Foundation.Rect lastRealizedLayoutBounds)
		{
			throw new global::System.NotImplementedException("The member Rect FlowLayout.GetExtent(Size availableSize, VirtualizingLayoutContext context, UIElement firstRealized, int firstRealizedItemIndex, Rect firstRealizedLayoutBounds, UIElement lastRealized, int lastRealizedItemIndex, Rect lastRealizedLayoutBounds) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnElementMeasured( global::Microsoft.UI.Xaml.UIElement element,  int index,  global::Windows.Foundation.Size availableSize,  global::Windows.Foundation.Size measureSize,  global::Windows.Foundation.Size desiredSize,  global::Windows.Foundation.Size provisionalArrangeSize,  global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.FlowLayout", "void FlowLayout.OnElementMeasured(UIElement element, int index, Size availableSize, Size measureSize, Size desiredSize, Size provisionalArrangeSize, VirtualizingLayoutContext context)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnLineArranged( int startIndex,  int countInLine,  double lineSize,  global::Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.FlowLayout", "void FlowLayout.OnLineArranged(int startIndex, int countInLine, double lineSize, VirtualizingLayoutContext context)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.OrientationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.MinRowSpacingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.MinColumnSpacingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FlowLayout.LineAlignmentProperty.get
	}
}
