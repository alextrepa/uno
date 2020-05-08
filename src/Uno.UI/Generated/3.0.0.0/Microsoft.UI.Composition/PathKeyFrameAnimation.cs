#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PathKeyFrameAnimation : global::Microsoft.UI.Composition.KeyFrameAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::Microsoft.UI.Composition.CompositionPath path)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.PathKeyFrameAnimation", "void PathKeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, CompositionPath path)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::Microsoft.UI.Composition.CompositionPath path,  global::Microsoft.UI.Composition.CompositionEasingFunction easingFunction)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.PathKeyFrameAnimation", "void PathKeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, CompositionPath path, CompositionEasingFunction easingFunction)");
		}
		#endif
	}
}
