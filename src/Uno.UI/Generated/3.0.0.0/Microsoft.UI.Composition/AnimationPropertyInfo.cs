#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AnimationPropertyInfo : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.AnimationPropertyAccessMode AccessMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member AnimationPropertyAccessMode AnimationPropertyInfo.AccessMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.AnimationPropertyInfo", "AnimationPropertyAccessMode AnimationPropertyInfo.AccessMode");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.AnimationPropertyInfo.AccessMode.get
		// Forced skipping of method Microsoft.UI.Composition.AnimationPropertyInfo.AccessMode.set
	}
}
