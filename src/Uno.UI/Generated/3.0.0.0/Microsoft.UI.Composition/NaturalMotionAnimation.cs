#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NaturalMotionAnimation : global::Microsoft.UI.Composition.CompositionAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.AnimationStopBehavior StopBehavior
		{
			get
			{
				throw new global::System.NotImplementedException("The member AnimationStopBehavior NaturalMotionAnimation.StopBehavior is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.NaturalMotionAnimation", "AnimationStopBehavior NaturalMotionAnimation.StopBehavior");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan DelayTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan NaturalMotionAnimation.DelayTime is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.NaturalMotionAnimation", "TimeSpan NaturalMotionAnimation.DelayTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.AnimationDelayBehavior DelayBehavior
		{
			get
			{
				throw new global::System.NotImplementedException("The member AnimationDelayBehavior NaturalMotionAnimation.DelayBehavior is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.NaturalMotionAnimation", "AnimationDelayBehavior NaturalMotionAnimation.DelayBehavior");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.NaturalMotionAnimation.DelayBehavior.get
		// Forced skipping of method Microsoft.UI.Composition.NaturalMotionAnimation.DelayBehavior.set
		// Forced skipping of method Microsoft.UI.Composition.NaturalMotionAnimation.DelayTime.get
		// Forced skipping of method Microsoft.UI.Composition.NaturalMotionAnimation.DelayTime.set
		// Forced skipping of method Microsoft.UI.Composition.NaturalMotionAnimation.StopBehavior.get
		// Forced skipping of method Microsoft.UI.Composition.NaturalMotionAnimation.StopBehavior.set
	}
}