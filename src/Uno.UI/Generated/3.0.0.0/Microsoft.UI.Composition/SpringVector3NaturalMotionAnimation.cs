#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpringVector3NaturalMotionAnimation : global::Microsoft.UI.Composition.Vector3NaturalMotionAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan Period
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan SpringVector3NaturalMotionAnimation.Period is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.SpringVector3NaturalMotionAnimation", "TimeSpan SpringVector3NaturalMotionAnimation.Period");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float DampingRatio
		{
			get
			{
				throw new global::System.NotImplementedException("The member float SpringVector3NaturalMotionAnimation.DampingRatio is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.SpringVector3NaturalMotionAnimation", "float SpringVector3NaturalMotionAnimation.DampingRatio");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.SpringVector3NaturalMotionAnimation.DampingRatio.get
		// Forced skipping of method Microsoft.UI.Composition.SpringVector3NaturalMotionAnimation.DampingRatio.set
		// Forced skipping of method Microsoft.UI.Composition.SpringVector3NaturalMotionAnimation.Period.get
		// Forced skipping of method Microsoft.UI.Composition.SpringVector3NaturalMotionAnimation.Period.set
	}
}