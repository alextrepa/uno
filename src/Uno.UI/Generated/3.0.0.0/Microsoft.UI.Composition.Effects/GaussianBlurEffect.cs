#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class GaussianBlurEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource GaussianBlurEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.GaussianBlurEffect", "IGraphicsEffectSource GaussianBlurEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.EffectOptimization Optimization
		{
			get
			{
				throw new global::System.NotImplementedException("The member EffectOptimization GaussianBlurEffect.Optimization is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.GaussianBlurEffect", "EffectOptimization GaussianBlurEffect.Optimization");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.EffectBorderMode BorderMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member EffectBorderMode GaussianBlurEffect.BorderMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.GaussianBlurEffect", "EffectBorderMode GaussianBlurEffect.BorderMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float BlurAmount
		{
			get
			{
				throw new global::System.NotImplementedException("The member float GaussianBlurEffect.BlurAmount is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.GaussianBlurEffect", "float GaussianBlurEffect.BlurAmount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string GaussianBlurEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.GaussianBlurEffect", "string GaussianBlurEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.BlurAmount.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.BlurAmount.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.Optimization.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.Optimization.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.BorderMode.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.BorderMode.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.GaussianBlurEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
