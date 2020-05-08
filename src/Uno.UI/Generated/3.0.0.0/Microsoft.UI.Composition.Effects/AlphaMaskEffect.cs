#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class AlphaMaskEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource AlphaMaskEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.AlphaMaskEffect", "IGraphicsEffectSource AlphaMaskEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Mask
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource AlphaMaskEffect.Mask is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.AlphaMaskEffect", "IGraphicsEffectSource AlphaMaskEffect.Mask");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AlphaMaskEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.AlphaMaskEffect", "string AlphaMaskEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.AlphaMaskEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.AlphaMaskEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.AlphaMaskEffect.Mask.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.AlphaMaskEffect.Mask.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.AlphaMaskEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.AlphaMaskEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
