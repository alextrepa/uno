#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ColorKeyFrameAnimation : global::Microsoft.UI.Composition.KeyFrameAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionColorSpace InterpolationColorSpace
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionColorSpace ColorKeyFrameAnimation.InterpolationColorSpace is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.ColorKeyFrameAnimation", "CompositionColorSpace ColorKeyFrameAnimation.InterpolationColorSpace");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.ColorKeyFrameAnimation.InterpolationColorSpace.get
		// Forced skipping of method Microsoft.UI.Composition.ColorKeyFrameAnimation.InterpolationColorSpace.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::Windows.UI.Color value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.ColorKeyFrameAnimation", "void ColorKeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, Color value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void InsertKeyFrame( float normalizedProgressKey,  global::Windows.UI.Color value,  global::Microsoft.UI.Composition.CompositionEasingFunction easingFunction)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.ColorKeyFrameAnimation", "void ColorKeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, Color value, CompositionEasingFunction easingFunction)");
		}
		#endif
	}
}