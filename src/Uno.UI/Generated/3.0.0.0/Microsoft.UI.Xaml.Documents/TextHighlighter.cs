#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextHighlighter 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush Foreground
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(ForegroundProperty);
			}
			set
			{
				this.SetValue(ForegroundProperty, value);
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
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Documents.TextRange> Ranges
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<TextRange> TextHighlighter.Ranges is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty BackgroundProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Background), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Documents.TextHighlighter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ForegroundProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Foreground), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Documents.TextHighlighter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TextHighlighter() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Documents.TextHighlighter", "TextHighlighter.TextHighlighter()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Documents.TextHighlighter.TextHighlighter()
		// Forced skipping of method Microsoft.UI.Xaml.Documents.TextHighlighter.Ranges.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.TextHighlighter.Foreground.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.TextHighlighter.Foreground.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.TextHighlighter.Background.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.TextHighlighter.Background.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.TextHighlighter.ForegroundProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.TextHighlighter.BackgroundProperty.get
	}
}
