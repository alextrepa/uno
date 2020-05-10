#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositeStepEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource CompositeStepEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.CompositeStepEffect", "IGraphicsEffectSource CompositeStepEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Effects.CanvasComposite Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CanvasComposite CompositeStepEffect.Mode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.CompositeStepEffect", "CanvasComposite CompositeStepEffect.Mode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Destination
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource CompositeStepEffect.Destination is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.CompositeStepEffect", "IGraphicsEffectSource CompositeStepEffect.Destination");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CompositeStepEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.CompositeStepEffect", "string CompositeStepEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.CompositeStepEffect.Mode.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.CompositeStepEffect.Mode.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.CompositeStepEffect.Destination.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.CompositeStepEffect.Destination.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.CompositeStepEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.CompositeStepEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.CompositeStepEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.CompositeStepEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
