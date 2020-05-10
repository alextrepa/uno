#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BorderEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource BorderEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.BorderEffect", "IGraphicsEffectSource BorderEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.CanvasEdgeBehavior ExtendY
		{
			get
			{
				throw new global::System.NotImplementedException("The member CanvasEdgeBehavior BorderEffect.ExtendY is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.BorderEffect", "CanvasEdgeBehavior BorderEffect.ExtendY");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.CanvasEdgeBehavior ExtendX
		{
			get
			{
				throw new global::System.NotImplementedException("The member CanvasEdgeBehavior BorderEffect.ExtendX is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.BorderEffect", "CanvasEdgeBehavior BorderEffect.ExtendX");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string BorderEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.BorderEffect", "string BorderEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.BorderEffect.ExtendX.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.BorderEffect.ExtendX.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.BorderEffect.ExtendY.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.BorderEffect.ExtendY.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.BorderEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.BorderEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.BorderEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.BorderEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
