#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SceneMeshRendererComponent : global::Windows.UI.Composition.Scenes.SceneRendererComponent
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Scenes.SceneMesh Mesh
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneMesh SceneMeshRendererComponent.Mesh is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Scenes.SceneMeshRendererComponent", "SceneMesh SceneMeshRendererComponent.Mesh");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Scenes.SceneMaterial Material
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneMaterial SceneMeshRendererComponent.Material is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Scenes.SceneMeshRendererComponent", "SceneMaterial SceneMeshRendererComponent.Material");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Scenes.SceneMeshMaterialAttributeMap UVMappings
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneMeshMaterialAttributeMap SceneMeshRendererComponent.UVMappings is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneMeshRendererComponent.Material.get
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneMeshRendererComponent.Material.set
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneMeshRendererComponent.Mesh.get
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneMeshRendererComponent.Mesh.set
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneMeshRendererComponent.UVMappings.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.Scenes.SceneMeshRendererComponent Create( global::Windows.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member SceneMeshRendererComponent SceneMeshRendererComponent.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
