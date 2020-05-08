#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class UnPremultiplyEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource UnPremultiplyEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.UnPremultiplyEffect", "IGraphicsEffectSource UnPremultiplyEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string UnPremultiplyEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.UnPremultiplyEffect", "string UnPremultiplyEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.UnPremultiplyEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.UnPremultiplyEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.UnPremultiplyEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.UnPremultiplyEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
