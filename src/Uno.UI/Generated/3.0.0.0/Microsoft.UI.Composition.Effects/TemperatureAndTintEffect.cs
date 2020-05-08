#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class TemperatureAndTintEffect : global::Windows.Graphics.Effects.IGraphicsEffect,global::Windows.Graphics.Effects.IGraphicsEffectSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Tint
		{
			get
			{
				throw new global::System.NotImplementedException("The member float TemperatureAndTintEffect.Tint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.TemperatureAndTintEffect", "float TemperatureAndTintEffect.Tint");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Temperature
		{
			get
			{
				throw new global::System.NotImplementedException("The member float TemperatureAndTintEffect.Temperature is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.TemperatureAndTintEffect", "float TemperatureAndTintEffect.Temperature");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Effects.IGraphicsEffectSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member IGraphicsEffectSource TemperatureAndTintEffect.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.TemperatureAndTintEffect", "IGraphicsEffectSource TemperatureAndTintEffect.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string TemperatureAndTintEffect.Name is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Effects.TemperatureAndTintEffect", "string TemperatureAndTintEffect.Name");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Effects.TemperatureAndTintEffect.Temperature.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.TemperatureAndTintEffect.Temperature.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.TemperatureAndTintEffect.Tint.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.TemperatureAndTintEffect.Tint.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.TemperatureAndTintEffect.Source.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.TemperatureAndTintEffect.Source.set
		// Forced skipping of method Microsoft.UI.Composition.Effects.TemperatureAndTintEffect.Name.get
		// Forced skipping of method Microsoft.UI.Composition.Effects.TemperatureAndTintEffect.Name.set
		// Processing: Windows.Graphics.Effects.IGraphicsEffect
		// Processing: Windows.Graphics.Effects.IGraphicsEffectSource
	}
}
