#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BounceScalarNaturalMotionAnimation : global::Microsoft.UI.Composition.ScalarNaturalMotionAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Restitution
		{
			get
			{
				throw new global::System.NotImplementedException("The member float BounceScalarNaturalMotionAnimation.Restitution is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation", "float BounceScalarNaturalMotionAnimation.Restitution");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Acceleration
		{
			get
			{
				throw new global::System.NotImplementedException("The member float BounceScalarNaturalMotionAnimation.Acceleration is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation", "float BounceScalarNaturalMotionAnimation.Acceleration");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation.Acceleration.get
		// Forced skipping of method Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation.Acceleration.set
		// Forced skipping of method Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation.Restitution.get
		// Forced skipping of method Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation.Restitution.set
	}
}