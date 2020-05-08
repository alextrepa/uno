#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionLinearGradientBrush : global::Microsoft.UI.Composition.CompositionGradientBrush
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 StartPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionLinearGradientBrush.StartPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionLinearGradientBrush", "Vector2 CompositionLinearGradientBrush.StartPoint");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 EndPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionLinearGradientBrush.EndPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionLinearGradientBrush", "Vector2 CompositionLinearGradientBrush.EndPoint");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionLinearGradientBrush.EndPoint.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionLinearGradientBrush.EndPoint.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionLinearGradientBrush.StartPoint.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionLinearGradientBrush.StartPoint.set
	}
}
