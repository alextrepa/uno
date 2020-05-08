#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Scroller : global::Microsoft.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ZoomMode ZoomMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ZoomMode)this.GetValue(ZoomModeProperty);
			}
			set
			{
				this.SetValue(ZoomModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ChainingMode ZoomChainingMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ChainingMode)this.GetValue(ZoomChainingModeProperty);
			}
			set
			{
				this.SetValue(ZoomChainingModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.RailingMode VerticalScrollRailingMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.RailingMode)this.GetValue(VerticalScrollRailingModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollRailingModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollMode VerticalScrollMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollMode)this.GetValue(VerticalScrollModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController VerticalScrollController
		{
			get
			{
				throw new global::System.NotImplementedException("The member IScrollController Scroller.VerticalScrollController is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "IScrollController Scroller.VerticalScrollController");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ChainingMode VerticalScrollChainingMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ChainingMode)this.GetValue(VerticalScrollChainingModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollChainingModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalAnchorRatio
		{
			get
			{
				return (double)this.GetValue(VerticalAnchorRatioProperty);
			}
			set
			{
				this.SetValue(VerticalAnchorRatioProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double MinZoomFactor
		{
			get
			{
				return (double)this.GetValue(MinZoomFactorProperty);
			}
			set
			{
				this.SetValue(MinZoomFactorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double MaxZoomFactor
		{
			get
			{
				return (double)this.GetValue(MaxZoomFactorProperty);
			}
			set
			{
				this.SetValue(MaxZoomFactorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InputKind IgnoredInputKind
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.InputKind)this.GetValue(IgnoredInputKindProperty);
			}
			set
			{
				this.SetValue(IgnoredInputKindProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.RailingMode HorizontalScrollRailingMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.RailingMode)this.GetValue(HorizontalScrollRailingModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollRailingModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollMode HorizontalScrollMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollMode)this.GetValue(HorizontalScrollModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController HorizontalScrollController
		{
			get
			{
				throw new global::System.NotImplementedException("The member IScrollController Scroller.HorizontalScrollController is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "IScrollController Scroller.HorizontalScrollController");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ChainingMode HorizontalScrollChainingMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ChainingMode)this.GetValue(HorizontalScrollChainingModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollChainingModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalAnchorRatio
		{
			get
			{
				return (double)this.GetValue(HorizontalAnchorRatioProperty);
			}
			set
			{
				this.SetValue(HorizontalAnchorRatioProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ContentOrientation ContentOrientation
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ContentOrientation)this.GetValue(ContentOrientationProperty);
			}
			set
			{
				this.SetValue(ContentOrientationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Content
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(ContentProperty);
			}
			set
			{
				this.SetValue(ContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush Background
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(BackgroundProperty);
			}
			set
			{
				this.SetValue(BackgroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionPropertySet ExpressionAnimationSources
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionPropertySet Scroller.ExpressionAnimationSources is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ExtentHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Scroller.ExtentHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ExtentWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Scroller.ExtentWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Scroller.HorizontalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointBase> HorizontalSnapPoints
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ScrollSnapPointBase> Scroller.HorizontalSnapPoints is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ScrollableHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Scroller.ScrollableHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ScrollableWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Scroller.ScrollableWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InteractionState State
		{
			get
			{
				throw new global::System.NotImplementedException("The member InteractionState Scroller.State is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Scroller.VerticalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointBase> VerticalSnapPoints
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ScrollSnapPointBase> Scroller.VerticalSnapPoints is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ViewportHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Scroller.ViewportHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ViewportWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Scroller.ViewportWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float ZoomFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member float Scroller.ZoomFactor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Controls.Primitives.ZoomSnapPointBase> ZoomSnapPoints
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ZoomSnapPointBase> Scroller.ZoomSnapPoints is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty BackgroundProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Background), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentOrientationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ContentOrientation), typeof(global::Microsoft.UI.Xaml.Controls.ContentOrientation), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ContentOrientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Content), typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalAnchorRatioProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalAnchorRatio), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollChainingModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollChainingMode), typeof(global::Microsoft.UI.Xaml.Controls.ChainingMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ChainingMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollRailingModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollRailingMode), typeof(global::Microsoft.UI.Xaml.Controls.RailingMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.RailingMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IgnoredInputKindProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IgnoredInputKind), typeof(global::Microsoft.UI.Xaml.Controls.InputKind), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MaxZoomFactorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MaxZoomFactor), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinZoomFactorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinZoomFactor), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalAnchorRatioProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalAnchorRatio), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollChainingModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollChainingMode), typeof(global::Microsoft.UI.Xaml.Controls.ChainingMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ChainingMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollRailingModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollRailingMode), typeof(global::Microsoft.UI.Xaml.Controls.RailingMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.RailingMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomChainingModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ZoomChainingMode), typeof(global::Microsoft.UI.Xaml.Controls.ChainingMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ChainingMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ZoomMode), typeof(global::Microsoft.UI.Xaml.Controls.ZoomMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Scroller), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ZoomMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public Scroller() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "Scroller.Scroller()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.Scroller()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.Background.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.Background.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.Content.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.Content.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ExpressionAnimationSources.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ExtentWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ExtentHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ViewportWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ViewportHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ScrollableWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ScrollableHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ContentOrientation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ContentOrientation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollChainingMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollChainingMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollChainingMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollChainingMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollRailingMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollRailingMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollRailingMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollRailingMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomChainingMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomChainingMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.IgnoredInputKind.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.IgnoredInputKind.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.MinZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.MinZoomFactor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.MaxZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.MaxZoomFactor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.State.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollController.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollController.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollController.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollController.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalAnchorRatio.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalAnchorRatio.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalAnchorRatio.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalAnchorRatio.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalSnapPoints.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalSnapPoints.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomSnapPoints.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo ScrollTo( double horizontalOffset,  double verticalOffset)
		{
			throw new global::System.NotImplementedException("The member ScrollInfo Scroller.ScrollTo(double horizontalOffset, double verticalOffset) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo ScrollTo( double horizontalOffset,  double verticalOffset,  global::Microsoft.UI.Xaml.Controls.ScrollOptions options)
		{
			throw new global::System.NotImplementedException("The member ScrollInfo Scroller.ScrollTo(double horizontalOffset, double verticalOffset, ScrollOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo ScrollBy( double horizontalOffsetDelta,  double verticalOffsetDelta)
		{
			throw new global::System.NotImplementedException("The member ScrollInfo Scroller.ScrollBy(double horizontalOffsetDelta, double verticalOffsetDelta) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo ScrollBy( double horizontalOffsetDelta,  double verticalOffsetDelta,  global::Microsoft.UI.Xaml.Controls.ScrollOptions options)
		{
			throw new global::System.NotImplementedException("The member ScrollInfo Scroller.ScrollBy(double horizontalOffsetDelta, double verticalOffsetDelta, ScrollOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo ScrollFrom( global::System.Numerics.Vector2 offsetsVelocity,  global::System.Numerics.Vector2? inertiaDecayRate)
		{
			throw new global::System.NotImplementedException("The member ScrollInfo Scroller.ScrollFrom(Vector2 offsetsVelocity, Vector2? inertiaDecayRate) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ZoomInfo ZoomTo( float zoomFactor,  global::System.Numerics.Vector2? centerPoint)
		{
			throw new global::System.NotImplementedException("The member ZoomInfo Scroller.ZoomTo(float zoomFactor, Vector2? centerPoint) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ZoomInfo ZoomTo( float zoomFactor,  global::System.Numerics.Vector2? centerPoint,  global::Microsoft.UI.Xaml.Controls.ZoomOptions options)
		{
			throw new global::System.NotImplementedException("The member ZoomInfo Scroller.ZoomTo(float zoomFactor, Vector2? centerPoint, ZoomOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ZoomInfo ZoomBy( float zoomFactorDelta,  global::System.Numerics.Vector2? centerPoint)
		{
			throw new global::System.NotImplementedException("The member ZoomInfo Scroller.ZoomBy(float zoomFactorDelta, Vector2? centerPoint) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ZoomInfo ZoomBy( float zoomFactorDelta,  global::System.Numerics.Vector2? centerPoint,  global::Microsoft.UI.Xaml.Controls.ZoomOptions options)
		{
			throw new global::System.NotImplementedException("The member ZoomInfo Scroller.ZoomBy(float zoomFactorDelta, Vector2? centerPoint, ZoomOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ZoomInfo ZoomFrom( float zoomFactorVelocity,  global::System.Numerics.Vector2? centerPoint,  float? inertiaDecayRate)
		{
			throw new global::System.NotImplementedException("The member ZoomInfo Scroller.ZoomFrom(float zoomFactorVelocity, Vector2? centerPoint, float? inertiaDecayRate) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ExtentChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ExtentChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.StateChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.StateChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ViewChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ViewChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ScrollAnimationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ScrollAnimationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomAnimationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomAnimationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ScrollCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ScrollCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.BringingIntoView.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.BringingIntoView.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.AnchorRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.AnchorRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.BackgroundProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ContentOrientationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollChainingModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollChainingModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollRailingModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollRailingModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalScrollModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalScrollModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomChainingModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.ZoomModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.IgnoredInputKindProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.MinZoomFactorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.MaxZoomFactorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.HorizontalAnchorRatioProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Scroller.VerticalAnchorRatioProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, global::Microsoft.UI.Xaml.Controls.ScrollerAnchorRequestedEventArgs> AnchorRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ScrollerAnchorRequestedEventArgs> Scroller.AnchorRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ScrollerAnchorRequestedEventArgs> Scroller.AnchorRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, global::Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs> BringingIntoView
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ScrollerBringingIntoViewEventArgs> Scroller.BringingIntoView");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ScrollerBringingIntoViewEventArgs> Scroller.BringingIntoView");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, object> ExtentChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, object> Scroller.ExtentChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, object> Scroller.ExtentChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, global::Microsoft.UI.Xaml.Controls.ScrollAnimationStartingEventArgs> ScrollAnimationStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ScrollAnimationStartingEventArgs> Scroller.ScrollAnimationStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ScrollAnimationStartingEventArgs> Scroller.ScrollAnimationStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, global::Microsoft.UI.Xaml.Controls.ScrollCompletedEventArgs> ScrollCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ScrollCompletedEventArgs> Scroller.ScrollCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ScrollCompletedEventArgs> Scroller.ScrollCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, object> StateChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, object> Scroller.StateChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, object> Scroller.StateChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, object> ViewChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, object> Scroller.ViewChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, object> Scroller.ViewChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, global::Microsoft.UI.Xaml.Controls.ZoomAnimationStartingEventArgs> ZoomAnimationStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ZoomAnimationStartingEventArgs> Scroller.ZoomAnimationStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ZoomAnimationStartingEventArgs> Scroller.ZoomAnimationStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.Scroller, global::Microsoft.UI.Xaml.Controls.ZoomCompletedEventArgs> ZoomCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ZoomCompletedEventArgs> Scroller.ZoomCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Scroller", "event TypedEventHandler<Scroller, ZoomCompletedEventArgs> Scroller.ZoomCompleted");
			}
		}
		#endif
	}
}
