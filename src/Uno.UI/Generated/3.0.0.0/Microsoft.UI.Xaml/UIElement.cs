#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class UIElement : global::Microsoft.UI.Composition.IAnimationObject,global::Microsoft.UI.Composition.IVisualElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double KeyTipVerticalOffset
		{
			get
			{
				return (double)this.GetValue(KeyTipVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(KeyTipVerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.KeyTipPlacementMode KeyTipPlacementMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Input.KeyTipPlacementMode)this.GetValue(KeyTipPlacementModeProperty);
			}
			set
			{
				this.SetValue(KeyTipPlacementModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double KeyTipHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(KeyTipHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(KeyTipHorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsTapEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsRightTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsRightTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsRightTapEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsHoldingEnabled
		{
			get
			{
				return (bool)this.GetValue(IsHoldingEnabledProperty);
			}
			set
			{
				this.SetValue(IsHoldingEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsDoubleTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsDoubleTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsDoubleTapEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAccessKeyScope
		{
			get
			{
				return (bool)this.GetValue(IsAccessKeyScopeProperty);
			}
			set
			{
				this.SetValue(IsAccessKeyScopeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string AccessKey
		{
			get
			{
				return (string)this.GetValue(AccessKeyProperty);
			}
			set
			{
				this.SetValue(AccessKeyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ExitDisplayModeOnAccessKeyInvoked
		{
			get
			{
				return (bool)this.GetValue(ExitDisplayModeOnAccessKeyInvokedProperty);
			}
			set
			{
				this.SetValue(ExitDisplayModeOnAccessKeyInvokedProperty, value);
			}
		}
		#endif
		// Skipping already declared property ManipulationMode
		// Skipping already declared property ContextFlyout
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.ElementCompositeMode CompositeMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.ElementCompositeMode)this.GetValue(CompositeModeProperty);
			}
			set
			{
				this.SetValue(CompositeModeProperty, value);
			}
		}
		#endif
		// Skipping already declared property Clip
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 CenterPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 UIElement.CenterPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "Vector3 UIElement.CenterPoint");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Media3D.Transform3D Transform3D
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Media3D.Transform3D)this.GetValue(Transform3DProperty);
			}
			set
			{
				this.SetValue(Transform3DProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanBeScrollAnchor
		{
			get
			{
				return (bool)this.GetValue(CanBeScrollAnchorProperty);
			}
			set
			{
				this.SetValue(CanBeScrollAnchorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.CacheMode CacheMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.CacheMode)this.GetValue(CacheModeProperty);
			}
			set
			{
				this.SetValue(CacheModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AllowDrop
		{
			get
			{
				return (bool)this.GetValue(AllowDropProperty);
			}
			set
			{
				this.SetValue(AllowDropProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject KeyboardAcceleratorPlacementTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(KeyboardAcceleratorPlacementTargetProperty);
			}
			set
			{
				this.SetValue(KeyboardAcceleratorPlacementTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.KeyboardAcceleratorPlacementMode KeyboardAcceleratorPlacementMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Input.KeyboardAcceleratorPlacementMode)this.GetValue(KeyboardAcceleratorPlacementModeProperty);
			}
			set
			{
				this.SetValue(KeyboardAcceleratorPlacementModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject AccessKeyScopeOwner
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(AccessKeyScopeOwnerProperty);
			}
			set
			{
				this.SetValue(AccessKeyScopeOwnerProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.ElementHighContrastAdjustment HighContrastAdjustment
		{
			get
			{
				return (global::Microsoft.UI.Xaml.ElementHighContrastAdjustment)this.GetValue(HighContrastAdjustmentProperty);
			}
			set
			{
				this.SetValue(HighContrastAdjustmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.XamlRoot XamlRoot
		{
			get
			{
				throw new global::System.NotImplementedException("The member XamlRoot UIElement.XamlRoot is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "XamlRoot UIElement.XamlRoot");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy XYFocusUpNavigationStrategy
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy)this.GetValue(XYFocusUpNavigationStrategyProperty);
			}
			set
			{
				this.SetValue(XYFocusUpNavigationStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy XYFocusRightNavigationStrategy
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy)this.GetValue(XYFocusRightNavigationStrategyProperty);
			}
			set
			{
				this.SetValue(XYFocusRightNavigationStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy XYFocusLeftNavigationStrategy
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy)this.GetValue(XYFocusLeftNavigationStrategyProperty);
			}
			set
			{
				this.SetValue(XYFocusLeftNavigationStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.XYFocusKeyboardNavigationMode XYFocusKeyboardNavigation
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Input.XYFocusKeyboardNavigationMode)this.GetValue(XYFocusKeyboardNavigationProperty);
			}
			set
			{
				this.SetValue(XYFocusKeyboardNavigationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy XYFocusDownNavigationStrategy
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy)this.GetValue(XYFocusDownNavigationStrategyProperty);
			}
			set
			{
				this.SetValue(XYFocusDownNavigationStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanDrag
		{
			get
			{
				return (bool)this.GetValue(CanDragProperty);
			}
			set
			{
				this.SetValue(CanDragProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool UseLayoutRounding
		{
			get
			{
				return (bool)this.GetValue(UseLayoutRoundingProperty);
			}
			set
			{
				this.SetValue(UseLayoutRoundingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Vector3Transition TranslationTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3Transition UIElement.TranslationTransition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "Vector3Transition UIElement.TranslationTransition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 Translation
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 UIElement.Translation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "Vector3 UIElement.Translation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Matrix4x4 TransformMatrix
		{
			get
			{
				throw new global::System.NotImplementedException("The member Matrix4x4 UIElement.TransformMatrix is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "Matrix4x4 UIElement.TransformMatrix");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.KeyboardNavigationMode TabFocusNavigation
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Input.KeyboardNavigationMode)this.GetValue(TabFocusNavigationProperty);
			}
			set
			{
				this.SetValue(TabFocusNavigationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Vector3Transition ScaleTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3Transition UIElement.ScaleTransition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "Vector3Transition UIElement.ScaleTransition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RasterizationScale
		{
			get
			{
				throw new global::System.NotImplementedException("The member double UIElement.RasterizationScale is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "double UIElement.RasterizationScale");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Projection Projection
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Projection)this.GetValue(ProjectionProperty);
			}
			set
			{
				this.SetValue(ProjectionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 Scale
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 UIElement.Scale is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "Vector3 UIElement.Scale");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.ScalarTransition OpacityTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScalarTransition UIElement.OpacityTransition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "ScalarTransition UIElement.OpacityTransition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.ScalarTransition RotationTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScalarTransition UIElement.RotationTransition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "ScalarTransition UIElement.RotationTransition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 RotationAxis
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 UIElement.RotationAxis is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "Vector3 UIElement.RotationAxis");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Rotation
		{
			get
			{
				throw new global::System.NotImplementedException("The member float UIElement.Rotation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "float UIElement.Rotation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject KeyTipTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(KeyTipTargetProperty);
			}
			set
			{
				this.SetValue(KeyTipTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Shadow Shadow
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Shadow)this.GetValue(ShadowProperty);
			}
			set
			{
				this.SetValue(ShadowProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 ActualOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 UIElement.ActualOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 ActualSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 UIElement.ActualSize is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property DesiredSize
		// Skipping already declared property KeyboardAccelerators
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Media.XamlLight> Lights
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Media.XamlLight>)this.GetValue(LightsProperty);
			}
		}
		#endif
		// Skipping already declared property PointerCaptures
		// Skipping already declared property RenderSize
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.UIContext UIContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIContext UIElement.UIContext is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AccessKeyProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AccessKey), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AccessKeyScopeOwnerProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AccessKeyScopeOwner), typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AllowDropProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AllowDrop), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent BringIntoViewRequestedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.BringIntoViewRequestedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CacheModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CacheMode), typeof(global::Microsoft.UI.Xaml.Media.CacheMode), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.CacheMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanBeScrollAnchorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanBeScrollAnchor), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanDragProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanDrag), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent CharacterReceivedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.CharacterReceivedEvent is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property ClipProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CompositeModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CompositeMode), typeof(global::Microsoft.UI.Xaml.Media.ElementCompositeMode), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.ElementCompositeMode)));
		#endif
		// Skipping already declared property ContextFlyoutProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent ContextRequestedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.ContextRequestedEvent is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property DoubleTappedEvent
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent DragEnterEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DragEnterEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent DragLeaveEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DragLeaveEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent DragOverEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DragOverEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent DropEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DropEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ExitDisplayModeOnAccessKeyInvoked), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent GettingFocusEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.GettingFocusEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HighContrastAdjustmentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HighContrastAdjustment), typeof(global::Microsoft.UI.Xaml.ElementHighContrastAdjustment), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.ElementHighContrastAdjustment)));
		#endif
		// Skipping already declared property HoldingEvent
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsAccessKeyScopeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsAccessKeyScope), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsDoubleTapEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsDoubleTapEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsHoldingEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsHoldingEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsRightTapEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsRightTapEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsTapEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsTapEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property KeyDownEvent
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyTipHorizontalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTipHorizontalOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyTipPlacementModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTipPlacementMode), typeof(global::Microsoft.UI.Xaml.Input.KeyTipPlacementMode), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Input.KeyTipPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyTipTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTipTarget), typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyTipVerticalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTipVerticalOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		// Skipping already declared property KeyUpEvent
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyboardAcceleratorPlacementModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(KeyboardAcceleratorPlacementMode), typeof(global::Microsoft.UI.Xaml.Input.KeyboardAcceleratorPlacementMode), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Input.KeyboardAcceleratorPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyboardAcceleratorPlacementTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(KeyboardAcceleratorPlacementTarget), typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LightsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Lights), typeof(global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Media.XamlLight>), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Media.XamlLight>)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent LosingFocusEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.LosingFocusEvent is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property ManipulationCompletedEvent
		// Skipping already declared property ManipulationDeltaEvent
		// Skipping already declared property ManipulationInertiaStartingEvent
		// Skipping already declared property ManipulationModeProperty
		// Skipping already declared property ManipulationStartedEvent
		// Skipping already declared property ManipulationStartingEvent
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent NoFocusCandidateFoundEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.NoFocusCandidateFoundEvent is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property PointerCanceledEvent
		// Skipping already declared property PointerCaptureLostEvent
		// Skipping already declared property PointerCapturesProperty
		// Skipping already declared property PointerEnteredEvent
		// Skipping already declared property PointerExitedEvent
		// Skipping already declared property PointerMovedEvent
		// Skipping already declared property PointerPressedEvent
		// Skipping already declared property PointerReleasedEvent
		// Skipping already declared property PointerWheelChangedEvent
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent PreviewKeyDownEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PreviewKeyDownEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.RoutedEvent PreviewKeyUpEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PreviewKeyUpEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ProjectionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Projection), typeof(global::Microsoft.UI.Xaml.Media.Projection), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Projection)));
		#endif
		// Skipping already declared property RightTappedEvent
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ShadowProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Shadow), typeof(global::Microsoft.UI.Xaml.Media.Shadow), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Shadow)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabFocusNavigationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabFocusNavigation), typeof(global::Microsoft.UI.Xaml.Input.KeyboardNavigationMode), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Input.KeyboardNavigationMode)));
		#endif
		// Skipping already declared property TappedEvent
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty Transform3DProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Transform3D), typeof(global::Microsoft.UI.Xaml.Media.Media3D.Transform3D), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Media3D.Transform3D)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty UseLayoutRoundingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(UseLayoutRounding), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty XYFocusDownNavigationStrategyProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(XYFocusDownNavigationStrategy), typeof(global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty XYFocusKeyboardNavigationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(XYFocusKeyboardNavigation), typeof(global::Microsoft.UI.Xaml.Input.XYFocusKeyboardNavigationMode), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Input.XYFocusKeyboardNavigationMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty XYFocusLeftNavigationStrategyProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(XYFocusLeftNavigationStrategy), typeof(global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty XYFocusRightNavigationStrategyProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(XYFocusRightNavigationStrategy), typeof(global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty XYFocusUpNavigationStrategyProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(XYFocusUpNavigationStrategy), typeof(global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy), 
			typeof(global::Microsoft.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Input.XYFocusNavigationStrategy)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DesiredSize.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AllowDrop.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AllowDrop.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Opacity.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Opacity.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Clip.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Clip.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RenderTransform.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RenderTransform.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Projection.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Projection.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Transform3D.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Transform3D.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RenderTransformOrigin.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RenderTransformOrigin.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsHitTestVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsHitTestVisible.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Visibility.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Visibility.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RenderSize.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.UseLayoutRounding.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.UseLayoutRounding.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Transitions.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Transitions.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CacheMode.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CacheMode.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsTapEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsTapEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsDoubleTapEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsDoubleTapEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CanDrag.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CanDrag.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsRightTapEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsRightTapEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsHoldingEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsHoldingEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationMode.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationMode.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerCaptures.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ContextFlyout.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ContextFlyout.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CompositeMode.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CompositeMode.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Lights.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CanBeScrollAnchor.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CanBeScrollAnchor.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvoked.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvoked.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsAccessKeyScope.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsAccessKeyScope.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyScopeOwner.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyScopeOwner.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKey.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKey.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipPlacementMode.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipPlacementMode.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipHorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipHorizontalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipVerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipVerticalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusKeyboardNavigation.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusKeyboardNavigation.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusUpNavigationStrategy.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusUpNavigationStrategy.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusDownNavigationStrategy.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusDownNavigationStrategy.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusLeftNavigationStrategy.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusLeftNavigationStrategy.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusRightNavigationStrategy.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusRightNavigationStrategy.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyboardAccelerators.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyboardAcceleratorPlacementMode.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyboardAcceleratorPlacementMode.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.HighContrastAdjustment.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.HighContrastAdjustment.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TabFocusNavigation.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TabFocusNavigation.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.OpacityTransition.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.OpacityTransition.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Translation.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Translation.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TranslationTransition.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TranslationTransition.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Rotation.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Rotation.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RotationTransition.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RotationTransition.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Scale.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Scale.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ScaleTransition.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ScaleTransition.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TransformMatrix.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TransformMatrix.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CenterPoint.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CenterPoint.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RotationAxis.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RotationAxis.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ActualOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ActualSize.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XamlRoot.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XamlRoot.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.UIContext.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Shadow.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Shadow.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RasterizationScale.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RasterizationScale.set
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyUp.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyUp.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyDown.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyDown.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.GotFocus.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.GotFocus.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.LostFocus.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.LostFocus.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DropCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DropCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CharacterReceived.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CharacterReceived.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragEnter.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragEnter.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragLeave.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragLeave.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragOver.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragOver.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Drop.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Drop.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerPressed.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerPressed.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerMoved.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerMoved.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerReleased.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerReleased.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerEntered.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerEntered.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerExited.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerExited.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerCaptureLost.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerCaptureLost.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerCanceled.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerCanceled.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerWheelChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerWheelChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Tapped.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Tapped.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DoubleTapped.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DoubleTapped.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Holding.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Holding.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ContextRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ContextRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ContextCanceled.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ContextCanceled.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RightTapped.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RightTapped.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationInertiaStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationInertiaStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationStarted.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationStarted.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationDelta.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationDelta.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyDisplayRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyDisplayRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyDisplayDismissed.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyDisplayDismissed.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyInvoked.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyInvoked.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ProcessKeyboardAccelerators.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ProcessKeyboardAccelerators.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.GettingFocus.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.GettingFocus.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.LosingFocus.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.LosingFocus.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.NoFocusCandidateFound.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.NoFocusCandidateFound.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PreviewKeyDown.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PreviewKeyDown.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PreviewKeyUp.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PreviewKeyUp.remove
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.BringIntoViewRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.BringIntoViewRequested.remove
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.Measure(Windows.Foundation.Size)
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.Arrange(Windows.Foundation.Rect)
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.CapturePointer(Microsoft.UI.Xaml.Input.Pointer)
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.ReleasePointerCapture(Microsoft.UI.Xaml.Input.Pointer)
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.ReleasePointerCaptures()
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.AddHandler(Microsoft.UI.Xaml.RoutedEvent, object, bool)
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.RemoveHandler(Microsoft.UI.Xaml.RoutedEvent, object)
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.TransformToVisual(Microsoft.UI.Xaml.UIElement)
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.InvalidateMeasure()
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.InvalidateArrange()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void UpdateLayout()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.UpdateLayout()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CancelDirectManipulations()
		{
			throw new global::System.NotImplementedException("The member bool UIElement.CancelDirectManipulations() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.DataTransfer.DataPackageOperation> StartDragAsync( global::Windows.UI.Input.PointerPoint pointerPoint)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DataPackageOperation> UIElement.StartDragAsync(PointerPoint pointerPoint) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.StartBringIntoView()
		// Skipping already declared method Microsoft.UI.Xaml.UIElement.StartBringIntoView(Microsoft.UI.Xaml.BringIntoViewOptions)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void TryInvokeKeyboardAccelerator( global::Microsoft.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void StartAnimation( global::Microsoft.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.StartAnimation(ICompositionAnimationBase animation)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void StopAnimation( global::Microsoft.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.StopAnimation(ICompositionAnimationBase animation)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Microsoft.UI.Xaml.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			throw new global::System.NotImplementedException("The member AutomationPeer UIElement.OnCreateAutomationPeer() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnDisconnectVisualChildren()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.OnDisconnectVisualChildren()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<global::Windows.Foundation.Point>> FindSubElementsForTouchTargeting( global::Windows.Foundation.Point point,  global::Windows.Foundation.Rect boundingRect)
		{
			throw new global::System.NotImplementedException("The member IEnumerable<IEnumerable<Point>> UIElement.FindSubElementsForTouchTargeting(Point point, Rect boundingRect) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::System.Collections.Generic.IEnumerable<global::Microsoft.UI.Xaml.DependencyObject> GetChildrenInTabFocusOrder()
		{
			throw new global::System.NotImplementedException("The member IEnumerable<DependencyObject> UIElement.GetChildrenInTabFocusOrder() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnKeyboardAcceleratorInvoked( global::Microsoft.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.OnKeyboardAcceleratorInvoked(KeyboardAcceleratorInvokedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnProcessKeyboardAccelerators( global::Microsoft.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.OnProcessKeyboardAccelerators(ProcessKeyboardAcceleratorEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnBringIntoViewRequested( global::Microsoft.UI.Xaml.BringIntoViewRequestedEventArgs e)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.OnBringIntoViewRequested(BringIntoViewRequestedEventArgs e)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void PopulatePropertyInfoOverride( string propertyName,  global::Microsoft.UI.Composition.AnimationPropertyInfo animationPropertyInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.PopulatePropertyInfoOverride(string propertyName, AnimationPropertyInfo animationPropertyInfo)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PopulatePropertyInfo( string propertyName,  global::Microsoft.UI.Composition.AnimationPropertyInfo propertyInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.PopulatePropertyInfo(string propertyName, AnimationPropertyInfo propertyInfo)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyDownEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyUpEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerEnteredEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerPressedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerMovedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerReleasedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerExitedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerCaptureLostEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerCanceledEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerWheelChangedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TappedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DoubleTappedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.HoldingEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RightTappedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationStartingEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationInertiaStartingEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationStartedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationDeltaEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationCompletedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragEnterEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragLeaveEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DragOverEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.DropEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.GettingFocusEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.LosingFocusEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.NoFocusCandidateFoundEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PreviewKeyDownEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CharacterReceivedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PreviewKeyUpEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.BringIntoViewRequestedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ContextRequestedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AllowDropProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.OpacityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ClipProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RenderTransformProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ProjectionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.Transform3DProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.RenderTransformOriginProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsHitTestVisibleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.VisibilityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.UseLayoutRoundingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TransitionsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CacheModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsTapEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsDoubleTapEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CanDragProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsRightTapEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsHoldingEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ManipulationModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.PointerCapturesProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ContextFlyoutProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CompositeModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.LightsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.CanBeScrollAnchorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvokedProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.IsAccessKeyScopeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyScopeOwnerProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.AccessKeyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipPlacementModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipHorizontalOffsetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipVerticalOffsetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyTipTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusKeyboardNavigationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusUpNavigationStrategyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusDownNavigationStrategyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusLeftNavigationStrategyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.XYFocusRightNavigationStrategyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.KeyboardAcceleratorPlacementModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.HighContrastAdjustmentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.TabFocusNavigationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElement.ShadowProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool TryStartDirectManipulation( global::Microsoft.UI.Xaml.Input.Pointer value)
		{
			throw new global::System.NotImplementedException("The member bool UIElement.TryStartDirectManipulation(Pointer value) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void RegisterAsScrollPort( global::Microsoft.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "void UIElement.RegisterAsScrollPort(UIElement element)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> UIElement.AccessKeyDisplayDismissed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> UIElement.AccessKeyDisplayDismissed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> UIElement.AccessKeyDisplayRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> UIElement.AccessKeyDisplayRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.AccessKeyInvokedEventArgs> AccessKeyInvoked
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> UIElement.AccessKeyInvoked");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> UIElement.AccessKeyInvoked");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.BringIntoViewRequestedEventArgs> BringIntoViewRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, BringIntoViewRequestedEventArgs> UIElement.BringIntoViewRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, BringIntoViewRequestedEventArgs> UIElement.BringIntoViewRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.CharacterReceivedRoutedEventArgs> CharacterReceived
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, CharacterReceivedRoutedEventArgs> UIElement.CharacterReceived");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, CharacterReceivedRoutedEventArgs> UIElement.CharacterReceived");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.RoutedEventArgs> ContextCanceled
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, RoutedEventArgs> UIElement.ContextCanceled");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, RoutedEventArgs> UIElement.ContextCanceled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.ContextRequestedEventArgs> ContextRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ContextRequestedEventArgs> UIElement.ContextRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ContextRequestedEventArgs> UIElement.ContextRequested");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.DoubleTapped
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.DragEventHandler DragEnter
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragEnter");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragEnter");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.DragEventHandler DragLeave
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragLeave");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragLeave");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.DragEventHandler DragOver
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragOver");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragOver");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.DragStartingEventArgs> DragStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, DragStartingEventArgs> UIElement.DragStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, DragStartingEventArgs> UIElement.DragStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.DragEventHandler Drop
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event DragEventHandler UIElement.Drop");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event DragEventHandler UIElement.Drop");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.DropCompletedEventArgs> DropCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, DropCompletedEventArgs> UIElement.DropCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, DropCompletedEventArgs> UIElement.DropCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.GettingFocusEventArgs> GettingFocus
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, GettingFocusEventArgs> UIElement.GettingFocus");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, GettingFocusEventArgs> UIElement.GettingFocus");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.GotFocus
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.Holding
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.KeyDown
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.KeyUp
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.LosingFocusEventArgs> LosingFocus
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, LosingFocusEventArgs> UIElement.LosingFocus");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, LosingFocusEventArgs> UIElement.LosingFocus");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.LostFocus
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.ManipulationCompleted
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.ManipulationDelta
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.ManipulationInertiaStarting
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.ManipulationStarted
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.ManipulationStarting
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.NoFocusCandidateFoundEventArgs> NoFocusCandidateFound
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, NoFocusCandidateFoundEventArgs> UIElement.NoFocusCandidateFound");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, NoFocusCandidateFoundEventArgs> UIElement.NoFocusCandidateFound");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.PointerCanceled
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.PointerCaptureLost
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.PointerEntered
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.PointerExited
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.PointerMoved
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.PointerPressed
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.PointerReleased
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.PointerWheelChanged
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Input.KeyEventHandler PreviewKeyDown
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyDown");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyDown");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Input.KeyEventHandler PreviewKeyUp
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyUp");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyUp");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.UIElement, global::Microsoft.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs> ProcessKeyboardAccelerators
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ProcessKeyboardAcceleratorEventArgs> UIElement.ProcessKeyboardAccelerators");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ProcessKeyboardAcceleratorEventArgs> UIElement.ProcessKeyboardAccelerators");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.RightTapped
		// Skipping already declared event Microsoft.UI.Xaml.UIElement.Tapped
		// Processing: Microsoft.UI.Composition.IAnimationObject
		// Processing: Microsoft.UI.Composition.IVisualElement
	}
}
