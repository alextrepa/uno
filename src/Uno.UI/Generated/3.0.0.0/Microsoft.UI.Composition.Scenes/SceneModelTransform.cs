#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SceneModelTransform : global::Microsoft.UI.Composition.CompositionTransform
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 Translation
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 SceneModelTransform.Translation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneModelTransform", "Vector3 SceneModelTransform.Translation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 Scale
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 SceneModelTransform.Scale is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneModelTransform", "Vector3 SceneModelTransform.Scale");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 RotationAxis
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 SceneModelTransform.RotationAxis is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneModelTransform", "Vector3 SceneModelTransform.RotationAxis");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float RotationAngleInDegrees
		{
			get
			{
				throw new global::System.NotImplementedException("The member float SceneModelTransform.RotationAngleInDegrees is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneModelTransform", "float SceneModelTransform.RotationAngleInDegrees");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float RotationAngle
		{
			get
			{
				throw new global::System.NotImplementedException("The member float SceneModelTransform.RotationAngle is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneModelTransform", "float SceneModelTransform.RotationAngle");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Quaternion Orientation
		{
			get
			{
				throw new global::System.NotImplementedException("The member Quaternion SceneModelTransform.Orientation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneModelTransform", "Quaternion SceneModelTransform.Orientation");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.Orientation.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.Orientation.set
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.RotationAngle.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.RotationAngle.set
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.RotationAngleInDegrees.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.RotationAngleInDegrees.set
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.RotationAxis.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.RotationAxis.set
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.Scale.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.Scale.set
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.Translation.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneModelTransform.Translation.set
	}
}
