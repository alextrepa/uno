#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ColorKeyFrame : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color Value
		{
			get
			{
				return (global::Windows.UI.Color)this.GetValue(ValueProperty);
			}
			set
			{
				this.SetValue(ValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Animation.KeyTime KeyTime
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.KeyTime)this.GetValue(KeyTimeProperty);
			}
			set
			{
				this.SetValue(KeyTimeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyTimeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTime), typeof(global::Microsoft.UI.Xaml.Media.Animation.KeyTime), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.KeyTime)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ValueProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Value), typeof(global::Windows.UI.Color), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Color)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		protected ColorKeyFrame() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame", "ColorKeyFrame.ColorKeyFrame()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame.ColorKeyFrame()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame.Value.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame.Value.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame.KeyTime.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame.KeyTime.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame.ValueProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame.KeyTimeProperty.get
	}
}
