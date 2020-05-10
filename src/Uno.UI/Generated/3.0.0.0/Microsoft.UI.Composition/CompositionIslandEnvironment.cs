#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionIslandEnvironment 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 DefaultOrientation
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 CompositionIslandEnvironment.DefaultOrientation is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float DefaultRasterizationScale
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CompositionIslandEnvironment.DefaultRasterizationScale is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float DisplayScale
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CompositionIslandEnvironment.DisplayScale is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionIslandEnvironment.DefaultOrientation.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionIslandEnvironment.DefaultRasterizationScale.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionIslandEnvironment.DisplayScale.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ChangeValues( global::System.Numerics.Vector3 defaultOrientation,  float defaultRasterizationScale,  float displayScale)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionIslandEnvironment", "void CompositionIslandEnvironment.ChangeValues(Vector3 defaultOrientation, float defaultRasterizationScale, float displayScale)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Composition.CompositionIslandEnvironment Create()
		{
			throw new global::System.NotImplementedException("The member CompositionIslandEnvironment CompositionIslandEnvironment.Create() is not implemented in Uno.");
		}
		#endif
	}
}
