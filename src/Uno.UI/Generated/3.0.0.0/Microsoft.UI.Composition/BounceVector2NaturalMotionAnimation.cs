#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BounceVector2NaturalMotionAnimation : global::Microsoft.UI.Composition.Vector2NaturalMotionAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Restitution
		{
			get
			{
				throw new global::System.NotImplementedException("The member float BounceVector2NaturalMotionAnimation.Restitution is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.BounceVector2NaturalMotionAnimation", "float BounceVector2NaturalMotionAnimation.Restitution");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Acceleration
		{
			get
			{
				throw new global::System.NotImplementedException("The member float BounceVector2NaturalMotionAnimation.Acceleration is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.BounceVector2NaturalMotionAnimation", "float BounceVector2NaturalMotionAnimation.Acceleration");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.BounceVector2NaturalMotionAnimation.Acceleration.get
		// Forced skipping of method Microsoft.UI.Composition.BounceVector2NaturalMotionAnimation.Acceleration.set
		// Forced skipping of method Microsoft.UI.Composition.BounceVector2NaturalMotionAnimation.Restitution.get
		// Forced skipping of method Microsoft.UI.Composition.BounceVector2NaturalMotionAnimation.Restitution.set
	}
}
