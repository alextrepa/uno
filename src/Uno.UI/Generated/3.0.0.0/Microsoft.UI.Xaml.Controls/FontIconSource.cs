#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FontIconSource : global::Microsoft.UI.Xaml.Controls.IconSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool MirroredWhenRightToLeft
		{
			get
			{
				return (bool)this.GetValue(MirroredWhenRightToLeftProperty);
			}
			set
			{
				this.SetValue(MirroredWhenRightToLeftProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsTextScaleFactorEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTextScaleFactorEnabledProperty);
			}
			set
			{
				this.SetValue(IsTextScaleFactorEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Glyph
		{
			get
			{
				return (string)this.GetValue(GlyphProperty);
			}
			set
			{
				this.SetValue(GlyphProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Text.FontWeight FontWeight
		{
			get
			{
				return (global::Windows.UI.Text.FontWeight)this.GetValue(FontWeightProperty);
			}
			set
			{
				this.SetValue(FontWeightProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Text.FontStyle FontStyle
		{
			get
			{
				return (global::Windows.UI.Text.FontStyle)this.GetValue(FontStyleProperty);
			}
			set
			{
				this.SetValue(FontStyleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double FontSize
		{
			get
			{
				return (double)this.GetValue(FontSizeProperty);
			}
			set
			{
				this.SetValue(FontSizeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.FontFamily FontFamily
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.FontFamily)this.GetValue(FontFamilyProperty);
			}
			set
			{
				this.SetValue(FontFamilyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FontFamilyProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(FontFamily), typeof(global::Microsoft.UI.Xaml.Media.FontFamily), 
			typeof(global::Microsoft.UI.Xaml.Controls.FontIconSource), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.FontFamily)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FontSizeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(FontSize), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.FontIconSource), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FontStyleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(FontStyle), typeof(global::Windows.UI.Text.FontStyle), 
			typeof(global::Microsoft.UI.Xaml.Controls.FontIconSource), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Text.FontStyle)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FontWeightProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(FontWeight), typeof(global::Windows.UI.Text.FontWeight), 
			typeof(global::Microsoft.UI.Xaml.Controls.FontIconSource), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Text.FontWeight)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty GlyphProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Glyph), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.FontIconSource), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsTextScaleFactorEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsTextScaleFactorEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.FontIconSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MirroredWhenRightToLeftProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MirroredWhenRightToLeft), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.FontIconSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public FontIconSource() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.FontIconSource", "FontIconSource.FontIconSource()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontIconSource()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.Glyph.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.Glyph.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontSize.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontSize.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontFamily.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontFamily.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontWeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontWeight.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontStyle.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.IsTextScaleFactorEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.IsTextScaleFactorEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.MirroredWhenRightToLeft.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.MirroredWhenRightToLeft.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.GlyphProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontSizeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontFamilyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontWeightProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.FontStyleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.IsTextScaleFactorEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.FontIconSource.MirroredWhenRightToLeftProperty.get
	}
}
