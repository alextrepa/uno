#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Transform2DEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Matrix3x2 TransformMatrix
		{
			get
			{
				throw new global::System.NotImplementedException("The member Matrix3x2 Transform2DEffect.TransformMatrix is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.Transform2DEffect", "Matrix3x2 Transform2DEffect.TransformMatrix");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource Transform2DEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.Transform2DEffect", "IGraphicsEffectSource Transform2DEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Sharpness
		{
			get
			{
				throw new global::System.NotImplementedException("The member float Transform2DEffect.Sharpness is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.Transform2DEffect", "float Transform2DEffect.Sharpness");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.CanvasImageInterpolation InterpolationMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CanvasImageInterpolation Transform2DEffect.InterpolationMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.Transform2DEffect", "CanvasImageInterpolation Transform2DEffect.InterpolationMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.EffectBorderMode BorderMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member EffectBorderMode Transform2DEffect.BorderMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.Transform2DEffect", "EffectBorderMode Transform2DEffect.BorderMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Transform2DEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.Transform2DEffect", "string Transform2DEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.InterpolationMode.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.InterpolationMode.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.BorderMode.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.BorderMode.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.TransformMatrix.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.TransformMatrix.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.Sharpness.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.Sharpness.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.Transform2DEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
