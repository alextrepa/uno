#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ToolTip : global::Microsoft.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalOffset
		{
			get
			{
				return (double)this.GetValue(VerticalOffsetProperty);
			}
			set
			{
				this.SetValue(VerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement PlacementTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(PlacementTargetProperty);
			}
			set
			{
				this.SetValue(PlacementTargetProperty, value);
			}
		}
		#endif
		// Skipping already declared property Placement
		// Skipping already declared property IsOpen
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalOffset
		{
			get
			{
				return (double)this.GetValue(HorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(HorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.ToolTipTemplateSettings TemplateSettings
		{
			get
			{
				throw new global::System.NotImplementedException("The member ToolTipTemplateSettings ToolTip.TemplateSettings is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Rect? PlacementRect
		{
			get
			{
				return (global::Windows.Foundation.Rect?)this.GetValue(PlacementRectProperty);
			}
			set
			{
				this.SetValue(PlacementRectProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		// Skipping already declared property IsOpenProperty
		// Skipping already declared property PlacementProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PlacementTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PlacementTarget), typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PlacementRectProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PlacementRect), typeof(global::Windows.Foundation.Rect?), 
			typeof(global::Microsoft.UI.Xaml.Controls.ToolTip), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Rect?)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ToolTip.ToolTip()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.ToolTip()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.HorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.HorizontalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.IsOpen.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.IsOpen.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.Placement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.Placement.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.PlacementTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.PlacementTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.VerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.VerticalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.TemplateSettings.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.Closed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.Closed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.Opened.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.Opened.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.PlacementRect.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.PlacementRect.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.PlacementRectProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.HorizontalOffsetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.IsOpenProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.PlacementProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.PlacementTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTip.VerticalOffsetProperty.get
		// Skipping already declared event Microsoft.UI.Xaml.Controls.ToolTip.Closed
		// Skipping already declared event Microsoft.UI.Xaml.Controls.ToolTip.Opened
	}
}