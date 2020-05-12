#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SwipeHintThemeAnimation : global::Microsoft.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ToVerticalOffset
		{
			get
			{
				return (double)this.GetValue(ToVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(ToVerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ToHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(ToHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(ToHorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string TargetName
		{
			get
			{
				return (string)this.GetValue(TargetNameProperty);
			}
			set
			{
				this.SetValue(TargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TargetNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TargetName), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ToHorizontalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ToHorizontalOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ToVerticalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ToVerticalOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SwipeHintThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation", "SwipeHintThemeAnimation.SwipeHintThemeAnimation()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.SwipeHintThemeAnimation()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.TargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.TargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToHorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToHorizontalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToVerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToVerticalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.TargetNameProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToHorizontalOffsetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SwipeHintThemeAnimation.ToVerticalOffsetProperty.get
	}
}