#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class GrayscaleEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource GrayscaleEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.GrayscaleEffect", "IGraphicsEffectSource GrayscaleEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string GrayscaleEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.GrayscaleEffect", "string GrayscaleEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.GrayscaleEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.GrayscaleEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.GrayscaleEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.GrayscaleEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
