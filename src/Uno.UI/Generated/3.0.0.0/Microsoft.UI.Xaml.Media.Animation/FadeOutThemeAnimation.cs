#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FadeOutThemeAnimation : global::Microsoft.UI.Xaml.Media.Animation.Timeline
	{
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
			typeof(global::Microsoft.UI.Xaml.Media.Animation.FadeOutThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public FadeOutThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.FadeOutThemeAnimation", "FadeOutThemeAnimation.FadeOutThemeAnimation()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.FadeOutThemeAnimation.FadeOutThemeAnimation()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.FadeOutThemeAnimation.TargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.FadeOutThemeAnimation.TargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.FadeOutThemeAnimation.TargetNameProperty.get
	}
}
