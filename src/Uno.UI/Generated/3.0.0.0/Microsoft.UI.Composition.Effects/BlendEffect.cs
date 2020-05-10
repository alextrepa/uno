#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BlendEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.BlendEffectMode Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member BlendEffectMode BlendEffect.Mode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.BlendEffect", "BlendEffectMode BlendEffect.Mode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Foreground
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource BlendEffect.Foreground is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.BlendEffect", "IGraphicsEffectSource BlendEffect.Foreground");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Background
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource BlendEffect.Background is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.BlendEffect", "IGraphicsEffectSource BlendEffect.Background");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BlendEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.BlendEffect", "string BlendEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.BlendEffect.Mode.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.BlendEffect.Mode.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.BlendEffect.Background.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.BlendEffect.Background.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.BlendEffect.Foreground.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.BlendEffect.Foreground.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.BlendEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.BlendEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
