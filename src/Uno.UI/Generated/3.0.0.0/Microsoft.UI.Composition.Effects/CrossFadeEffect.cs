#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CrossFadeEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Weight
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CrossFadeEffect.Weight is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.CrossFadeEffect", "float CrossFadeEffect.Weight");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source2
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource CrossFadeEffect.Source2 is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.CrossFadeEffect", "IGraphicsEffectSource CrossFadeEffect.Source2");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source1
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource CrossFadeEffect.Source1 is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.CrossFadeEffect", "IGraphicsEffectSource CrossFadeEffect.Source1");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CrossFadeEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.CrossFadeEffect", "string CrossFadeEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.CrossFadeEffect.Weight.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.CrossFadeEffect.Weight.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.CrossFadeEffect.Source1.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.CrossFadeEffect.Source1.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.CrossFadeEffect.Source2.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.CrossFadeEffect.Source2.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.CrossFadeEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.CrossFadeEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
