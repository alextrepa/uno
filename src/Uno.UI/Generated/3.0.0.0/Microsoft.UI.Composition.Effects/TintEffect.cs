#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TintEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource TintEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.TintEffect", "IGraphicsEffectSource TintEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color Color
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color TintEffect.Color is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.TintEffect", "Color TintEffect.Color");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ClampOutput
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TintEffect.ClampOutput is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.TintEffect", "bool TintEffect.ClampOutput");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string TintEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.TintEffect", "string TintEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.TintEffect.Color.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.TintEffect.Color.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.TintEffect.ClampOutput.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.TintEffect.ClampOutput.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.TintEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.TintEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.TintEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.TintEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
