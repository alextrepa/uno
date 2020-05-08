#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PointAnimation : global::Microsoft.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point? To
		{
			get
			{
				return (global::Windows.Foundation.Point?)this.GetValue(ToProperty);
			}
			set
			{
				this.SetValue(ToProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point? From
		{
			get
			{
				return (global::Windows.Foundation.Point?)this.GetValue(FromProperty);
			}
			set
			{
				this.SetValue(FromProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool EnableDependentAnimation
		{
			get
			{
				return (bool)this.GetValue(EnableDependentAnimationProperty);
			}
			set
			{
				this.SetValue(EnableDependentAnimationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase EasingFunction
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase)this.GetValue(EasingFunctionProperty);
			}
			set
			{
				this.SetValue(EasingFunctionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point? By
		{
			get
			{
				return (global::Windows.Foundation.Point?)this.GetValue(ByProperty);
			}
			set
			{
				this.SetValue(ByProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ByProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(By), typeof(global::Windows.Foundation.Point?), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PointAnimation), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Point?)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty EasingFunctionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(EasingFunction), typeof(global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PointAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty EnableDependentAnimationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(EnableDependentAnimation), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PointAnimation), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FromProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(From), typeof(global::Windows.Foundation.Point?), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PointAnimation), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Point?)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ToProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(To), typeof(global::Windows.Foundation.Point?), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PointAnimation), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Point?)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PointAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.PointAnimation", "PointAnimation.PointAnimation()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.PointAnimation()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.From.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.From.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.To.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.To.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.By.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.By.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.EasingFunction.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.EasingFunction.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.EnableDependentAnimation.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.EnableDependentAnimation.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.FromProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.ToProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.ByProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.EasingFunctionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimation.EnableDependentAnimationProperty.get
	}
}
