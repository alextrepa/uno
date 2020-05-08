#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SplitOpenThemeAnimation : global::Microsoft.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string OpenedTargetName
		{
			get
			{
				return (string)this.GetValue(OpenedTargetNameProperty);
			}
			set
			{
				this.SetValue(OpenedTargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject OpenedTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(OpenedTargetProperty);
			}
			set
			{
				this.SetValue(OpenedTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OpenedLength
		{
			get
			{
				return (double)this.GetValue(OpenedLengthProperty);
			}
			set
			{
				this.SetValue(OpenedLengthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OffsetFromCenter
		{
			get
			{
				return (double)this.GetValue(OffsetFromCenterProperty);
			}
			set
			{
				this.SetValue(OffsetFromCenterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ContentTranslationOffset
		{
			get
			{
				return (double)this.GetValue(ContentTranslationOffsetProperty);
			}
			set
			{
				this.SetValue(ContentTranslationOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.AnimationDirection ContentTranslationDirection
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Primitives.AnimationDirection)this.GetValue(ContentTranslationDirectionProperty);
			}
			set
			{
				this.SetValue(ContentTranslationDirectionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string ContentTargetName
		{
			get
			{
				return (string)this.GetValue(ContentTargetNameProperty);
			}
			set
			{
				this.SetValue(ContentTargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ContentTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(ContentTargetProperty);
			}
			set
			{
				this.SetValue(ContentTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string ClosedTargetName
		{
			get
			{
				return (string)this.GetValue(ClosedTargetNameProperty);
			}
			set
			{
				this.SetValue(ClosedTargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ClosedTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(ClosedTargetProperty);
			}
			set
			{
				this.SetValue(ClosedTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ClosedLength
		{
			get
			{
				return (double)this.GetValue(ClosedLengthProperty);
			}
			set
			{
				this.SetValue(ClosedLengthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ClosedLengthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ClosedLength), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ClosedTargetNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ClosedTargetName), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ClosedTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ClosedTarget), typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentTargetNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ContentTargetName), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ContentTarget), typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentTranslationDirectionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ContentTranslationDirection), typeof(global::Microsoft.UI.Xaml.Controls.Primitives.AnimationDirection), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.AnimationDirection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentTranslationOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ContentTranslationOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OffsetFromCenterProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(OffsetFromCenter), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OpenedLengthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(OpenedLength), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OpenedTargetNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(OpenedTargetName), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OpenedTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(OpenedTarget), typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SplitOpenThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation", "SplitOpenThemeAnimation.SplitOpenThemeAnimation()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.SplitOpenThemeAnimation()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedTargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedTargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedTargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedTargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OffsetFromCenter.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OffsetFromCenter.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTranslationDirection.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTranslationDirection.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTranslationOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTranslationOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedTargetNameProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedTargetNameProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTargetNameProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OpenedLengthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ClosedLengthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.OffsetFromCenterProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTranslationDirectionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitOpenThemeAnimation.ContentTranslationOffsetProperty.get
	}
}
