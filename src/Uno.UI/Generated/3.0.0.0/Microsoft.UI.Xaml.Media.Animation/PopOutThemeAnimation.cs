#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PopOutThemeAnimation : global::Microsoft.UI.Xaml.Media.Animation.Timeline
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
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PopOutThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PopOutThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.PopOutThemeAnimation", "PopOutThemeAnimation.PopOutThemeAnimation()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopOutThemeAnimation.PopOutThemeAnimation()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopOutThemeAnimation.TargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopOutThemeAnimation.TargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopOutThemeAnimation.TargetNameProperty.get
	}
}