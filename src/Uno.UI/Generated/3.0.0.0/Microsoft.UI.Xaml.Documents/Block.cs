#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Block : global::Microsoft.UI.Xaml.Documents.TextElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.TextAlignment TextAlignment
		{
			get
			{
				return (global::Microsoft.UI.Xaml.TextAlignment)this.GetValue(TextAlignmentProperty);
			}
			set
			{
				this.SetValue(TextAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Thickness Margin
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Thickness)this.GetValue(MarginProperty);
			}
			set
			{
				this.SetValue(MarginProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.LineStackingStrategy LineStackingStrategy
		{
			get
			{
				return (global::Microsoft.UI.Xaml.LineStackingStrategy)this.GetValue(LineStackingStrategyProperty);
			}
			set
			{
				this.SetValue(LineStackingStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double LineHeight
		{
			get
			{
				return (double)this.GetValue(LineHeightProperty);
			}
			set
			{
				this.SetValue(LineHeightProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.TextAlignment HorizontalTextAlignment
		{
			get
			{
				return (global::Microsoft.UI.Xaml.TextAlignment)this.GetValue(HorizontalTextAlignmentProperty);
			}
			set
			{
				this.SetValue(HorizontalTextAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LineHeightProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(LineHeight), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LineStackingStrategyProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(LineStackingStrategy), typeof(global::Microsoft.UI.Xaml.LineStackingStrategy), 
			typeof(global::Microsoft.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.LineStackingStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MarginProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Margin), typeof(global::Microsoft.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TextAlignmentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TextAlignment), typeof(global::Microsoft.UI.Xaml.TextAlignment), 
			typeof(global::Microsoft.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.TextAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalTextAlignmentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalTextAlignment), typeof(global::Microsoft.UI.Xaml.TextAlignment), 
			typeof(global::Microsoft.UI.Xaml.Documents.Block), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.TextAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected Block() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Documents.Block", "Block.Block()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.Block()
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.TextAlignment.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.TextAlignment.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.LineHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.LineHeight.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.LineStackingStrategy.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.LineStackingStrategy.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.Margin.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.Margin.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.HorizontalTextAlignment.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.HorizontalTextAlignment.set
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.HorizontalTextAlignmentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.TextAlignmentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.LineHeightProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.LineStackingStrategyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Documents.Block.MarginProperty.get
	}
}