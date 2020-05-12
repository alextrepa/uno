#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DropShadow : global::Microsoft.UI.Composition.CompositionShadow
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float Opacity
		{
			get
			{
				throw new global::System.NotImplementedException("The member float DropShadow.Opacity is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.DropShadow", "float DropShadow.Opacity");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 Offset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 DropShadow.Offset is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.DropShadow", "Vector3 DropShadow.Offset");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionBrush Mask
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush DropShadow.Mask is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.DropShadow", "CompositionBrush DropShadow.Mask");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color Color
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color DropShadow.Color is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.DropShadow", "Color DropShadow.Color");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float BlurRadius
		{
			get
			{
				throw new global::System.NotImplementedException("The member float DropShadow.BlurRadius is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.DropShadow", "float DropShadow.BlurRadius");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionDropShadowSourcePolicy SourcePolicy
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionDropShadowSourcePolicy DropShadow.SourcePolicy is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.DropShadow", "CompositionDropShadowSourcePolicy DropShadow.SourcePolicy");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.BlurRadius.get
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.BlurRadius.set
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.Color.get
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.Color.set
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.Mask.get
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.Mask.set
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.Offset.get
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.Offset.set
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.Opacity.get
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.Opacity.set
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.SourcePolicy.get
		// Forced skipping of method Microsoft.UI.Composition.DropShadow.SourcePolicy.set
	}
}