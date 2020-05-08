#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ThemeAnimationBase : global::Microsoft.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected ThemeAnimationBase() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.ThemeAnimationBase", "ThemeAnimationBase.ThemeAnimationBase()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ThemeAnimationBase.ThemeAnimationBase()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void CreateTimelinesInternal( bool onlyGenerateSteadyState,  global::Microsoft.UI.Xaml.Media.Animation.TimelineCollection timelineCollection)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.ThemeAnimationBase", "void ThemeAnimationBase.CreateTimelinesInternal(bool onlyGenerateSteadyState, TimelineCollection timelineCollection)");
		}
		#endif
	}
}
