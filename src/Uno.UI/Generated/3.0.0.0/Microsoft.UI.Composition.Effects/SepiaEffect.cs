#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SepiaEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource SepiaEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.SepiaEffect", "IGraphicsEffectSource SepiaEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Intensity
		{
			get
			{
				throw new global::System.NotImplementedException("The member float SepiaEffect.Intensity is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.SepiaEffect", "float SepiaEffect.Intensity");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.CanvasAlphaMode AlphaMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CanvasAlphaMode SepiaEffect.AlphaMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.SepiaEffect", "CanvasAlphaMode SepiaEffect.AlphaMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SepiaEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.SepiaEffect", "string SepiaEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.SepiaEffect.Intensity.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.SepiaEffect.Intensity.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.SepiaEffect.AlphaMode.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.SepiaEffect.AlphaMode.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.SepiaEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.SepiaEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.SepiaEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.SepiaEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
