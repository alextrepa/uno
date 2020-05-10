#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ColorMatrixEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource ColorMatrixEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ColorMatrixEffect", "IGraphicsEffectSource ColorMatrixEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.Matrix5x4 ColorMatrix
		{
			get
			{
				throw new global::System.NotImplementedException("The member Matrix5x4 ColorMatrixEffect.ColorMatrix is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ColorMatrixEffect", "Matrix5x4 ColorMatrixEffect.ColorMatrix");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ClampOutput
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ColorMatrixEffect.ClampOutput is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ColorMatrixEffect", "bool ColorMatrixEffect.ClampOutput");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.CanvasAlphaMode AlphaMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CanvasAlphaMode ColorMatrixEffect.AlphaMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ColorMatrixEffect", "CanvasAlphaMode ColorMatrixEffect.AlphaMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ColorMatrixEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ColorMatrixEffect", "string ColorMatrixEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.ColorMatrix.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.ColorMatrix.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.AlphaMode.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.AlphaMode.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.ClampOutput.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.ClampOutput.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ColorMatrixEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
