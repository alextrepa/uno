#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Glyphs : global::Microsoft.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string UnicodeString
		{
			get
			{
				return (string)this.GetValue(UnicodeStringProperty);
			}
			set
			{
				this.SetValue(UnicodeStringProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.StyleSimulations StyleSimulations
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.StyleSimulations)this.GetValue(StyleSimulationsProperty);
			}
			set
			{
				this.SetValue(StyleSimulationsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OriginY
		{
			get
			{
				return (double)this.GetValue(OriginYProperty);
			}
			set
			{
				this.SetValue(OriginYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OriginX
		{
			get
			{
				return (double)this.GetValue(OriginXProperty);
			}
			set
			{
				this.SetValue(OriginXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Indices
		{
			get
			{
				return (string)this.GetValue(IndicesProperty);
			}
			set
			{
				this.SetValue(IndicesProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Uri FontUri
		{
			get
			{
				return (global::System.Uri)this.GetValue(FontUriProperty);
			}
			set
			{
				this.SetValue(FontUriProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double FontRenderingEmSize
		{
			get
			{
				return (double)this.GetValue(FontRenderingEmSizeProperty);
			}
			set
			{
				this.SetValue(FontRenderingEmSizeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush Fill
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(FillProperty);
			}
			set
			{
				this.SetValue(FillProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsColorFontEnabled
		{
			get
			{
				return (bool)this.GetValue(IsColorFontEnabledProperty);
			}
			set
			{
				this.SetValue(IsColorFontEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int ColorFontPaletteIndex
		{
			get
			{
				return (int)this.GetValue(ColorFontPaletteIndexProperty);
			}
			set
			{
				this.SetValue(ColorFontPaletteIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FillProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Fill), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FontRenderingEmSizeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(FontRenderingEmSize), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FontUriProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(FontUri), typeof(global::System.Uri), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IndicesProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Indices), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OriginXProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(OriginX), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OriginYProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(OriginY), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty StyleSimulationsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(StyleSimulations), typeof(global::Microsoft.UI.Xaml.Media.StyleSimulations), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.StyleSimulations)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty UnicodeStringProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(UnicodeString), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ColorFontPaletteIndexProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ColorFontPaletteIndex), typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsColorFontEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsColorFontEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Documents.Glyphs), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public Glyphs() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Documents.Glyphs", "Glyphs.Glyphs()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.Glyphs()
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.UnicodeString.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.UnicodeString.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.Indices.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.Indices.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.FontUri.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.FontUri.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.StyleSimulations.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.StyleSimulations.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.FontRenderingEmSize.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.FontRenderingEmSize.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.OriginX.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.OriginX.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.OriginY.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.OriginY.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.Fill.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.Fill.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.IsColorFontEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.IsColorFontEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.ColorFontPaletteIndex.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.ColorFontPaletteIndex.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.IsColorFontEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.ColorFontPaletteIndexProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.UnicodeStringProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.IndicesProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.FontUriProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.StyleSimulationsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.FontRenderingEmSizeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.OriginXProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.OriginYProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Glyphs.FillProperty.get
	}
}
