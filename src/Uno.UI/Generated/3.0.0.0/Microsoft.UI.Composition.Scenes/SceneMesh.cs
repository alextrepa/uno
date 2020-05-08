#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SceneMesh : global::Microsoft.UI.Composition.Scenes.SceneObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Scenes.SceneBoundingBox Bounds
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneBoundingBox SceneMesh.Bounds is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneMesh.Bounds.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void FillMeshAttribute( global::Microsoft.UI.Composition.Scenes.SceneAttributeSemantic semantic,  global::Windows.Graphics.DirectX.DirectXPixelFormat format,  global::Windows.Foundation.MemoryBuffer memory)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneMesh", "void SceneMesh.FillMeshAttribute(SceneAttributeSemantic semantic, DirectXPixelFormat format, MemoryBuffer memory)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Composition.Scenes.SceneMesh Create( global::Microsoft.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member SceneMesh SceneMesh.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
