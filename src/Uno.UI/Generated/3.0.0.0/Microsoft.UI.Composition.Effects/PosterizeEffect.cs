#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PosterizeEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource PosterizeEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.PosterizeEffect", "IGraphicsEffectSource PosterizeEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int RedValueCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int PosterizeEffect.RedValueCount is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.PosterizeEffect", "int PosterizeEffect.RedValueCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int GreenValueCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int PosterizeEffect.GreenValueCount is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.PosterizeEffect", "int PosterizeEffect.GreenValueCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int BlueValueCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int PosterizeEffect.BlueValueCount is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.PosterizeEffect", "int PosterizeEffect.BlueValueCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PosterizeEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.PosterizeEffect", "string PosterizeEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.RedValueCount.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.RedValueCount.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.GreenValueCount.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.GreenValueCount.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.BlueValueCount.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.BlueValueCount.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.PosterizeEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
