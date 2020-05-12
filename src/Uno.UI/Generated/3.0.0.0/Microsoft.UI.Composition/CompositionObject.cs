#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionObject : global::System.IDisposable,global::Microsoft.UI.Composition.IAnimationObject
	{
		// Skipping already declared property Compositor
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionPropertySet Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionPropertySet CompositionObject.Properties is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.ImplicitAnimationCollection ImplicitAnimations
		{
			get
			{
				throw new global::System.NotImplementedException("The member ImplicitAnimationCollection CompositionObject.ImplicitAnimations is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionObject", "ImplicitAnimationCollection CompositionObject.ImplicitAnimations");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Comment
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CompositionObject.Comment is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionObject", "string CompositionObject.Comment");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.System.DispatcherQueue DispatcherQueue
		{
			get
			{
				throw new global::System.NotImplementedException("The member DispatcherQueue CompositionObject.DispatcherQueue is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionObject.Compositor.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionObject.Properties.get
		// Skipping already declared method Microsoft.UI.Composition.CompositionObject.StartAnimation(string, Microsoft.UI.Composition.CompositionAnimation)
		// Skipping already declared method Microsoft.UI.Composition.CompositionObject.StopAnimation(string)
		// Forced skipping of method Microsoft.UI.Composition.CompositionObject.Comment.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionObject.Comment.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionObject.ImplicitAnimations.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionObject.ImplicitAnimations.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void StartAnimationGroup( global::Microsoft.UI.Composition.ICompositionAnimationBase value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionObject", "void CompositionObject.StartAnimationGroup(ICompositionAnimationBase value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void StopAnimationGroup( global::Microsoft.UI.Composition.ICompositionAnimationBase value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionObject", "void CompositionObject.StopAnimationGroup(ICompositionAnimationBase value)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionObject.DispatcherQueue.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.AnimationController TryGetAnimationController( string propertyName)
		{
			throw new global::System.NotImplementedException("The member AnimationController CompositionObject.TryGetAnimationController(string propertyName) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionObject", "void CompositionObject.Dispose()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PopulatePropertyInfo( string propertyName,  global::Microsoft.UI.Composition.AnimationPropertyInfo propertyInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionObject", "void CompositionObject.PopulatePropertyInfo(string propertyName, AnimationPropertyInfo propertyInfo)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void StartAnimationWithIAnimationObject( global::Microsoft.UI.Composition.IAnimationObject target,  string propertyName,  global::Microsoft.UI.Composition.CompositionAnimation animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionObject", "void CompositionObject.StartAnimationWithIAnimationObject(IAnimationObject target, string propertyName, CompositionAnimation animation)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void StartAnimationGroupWithIAnimationObject( global::Microsoft.UI.Composition.IAnimationObject target,  global::Microsoft.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionObject", "void CompositionObject.StartAnimationGroupWithIAnimationObject(IAnimationObject target, ICompositionAnimationBase animation)");
		}
		#endif
		// Processing: System.IDisposable
		// Processing: Microsoft.UI.Composition.IAnimationObject
	}
}