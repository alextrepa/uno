#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SceneComponent : global::Windows.UI.Composition.Scenes.SceneObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Scenes.SceneComponentType ComponentType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneComponentType SceneComponent.ComponentType is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneComponent.ComponentType.get
	}
}
