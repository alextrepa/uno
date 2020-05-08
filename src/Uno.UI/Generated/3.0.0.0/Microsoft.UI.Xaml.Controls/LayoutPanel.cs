#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LayoutPanel : global::Microsoft.UI.Xaml.Controls.Panel
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Thickness Padding
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Thickness)this.GetValue(PaddingProperty);
			}
			set
			{
				this.SetValue(PaddingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Layout Layout
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Layout)this.GetValue(LayoutProperty);
			}
			set
			{
				this.SetValue(LayoutProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.CornerRadius CornerRadius
		{
			get
			{
				return (global::Microsoft.UI.Xaml.CornerRadius)this.GetValue(CornerRadiusProperty);
			}
			set
			{
				this.SetValue(CornerRadiusProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Thickness BorderThickness
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Thickness)this.GetValue(BorderThicknessProperty);
			}
			set
			{
				this.SetValue(BorderThicknessProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush BorderBrush
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(BorderBrushProperty);
			}
			set
			{
				this.SetValue(BorderBrushProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty BorderBrushProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(BorderBrush), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.LayoutPanel), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty BorderThicknessProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(BorderThickness), typeof(global::Microsoft.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Controls.LayoutPanel), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CornerRadiusProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CornerRadius), typeof(global::Microsoft.UI.Xaml.CornerRadius), 
			typeof(global::Microsoft.UI.Xaml.Controls.LayoutPanel), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.CornerRadius)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LayoutProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Layout), typeof(global::Microsoft.UI.Xaml.Controls.Layout), 
			typeof(global::Microsoft.UI.Xaml.Controls.LayoutPanel), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Layout)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PaddingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Padding), typeof(global::Microsoft.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Controls.LayoutPanel), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public LayoutPanel() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.LayoutPanel", "LayoutPanel.LayoutPanel()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.LayoutPanel()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.Layout.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.Layout.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.BorderBrush.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.BorderBrush.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.BorderThickness.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.BorderThickness.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.Padding.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.Padding.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.CornerRadius.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.CornerRadius.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.LayoutProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.BorderBrushProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.BorderThicknessProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.PaddingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.LayoutPanel.CornerRadiusProperty.get
	}
}
