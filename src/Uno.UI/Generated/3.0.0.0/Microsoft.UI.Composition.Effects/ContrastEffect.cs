#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContrastEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource ContrastEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ContrastEffect", "IGraphicsEffectSource ContrastEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Contrast
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ContrastEffect.Contrast is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ContrastEffect", "float ContrastEffect.Contrast");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ClampSource
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ContrastEffect.ClampSource is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ContrastEffect", "bool ContrastEffect.ClampSource");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ContrastEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.ContrastEffect", "string ContrastEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.ContrastEffect.Contrast.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ContrastEffect.Contrast.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.ContrastEffect.ClampSource.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ContrastEffect.ClampSource.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.ContrastEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ContrastEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.ContrastEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.ContrastEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
