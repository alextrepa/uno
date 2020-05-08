#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Internal
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SecondaryContentRelationship : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetAuxiliaryDependencyPropertyHolder( global::Microsoft.UI.Xaml.DependencyObject auxiliaryDependencyPropertyHolder)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Internal.SecondaryContentRelationship", "void SecondaryContentRelationship.SetAuxiliaryDependencyPropertyHolder(DependencyObject auxiliaryDependencyPropertyHolder)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PrepareForCurveUpdate()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Internal.SecondaryContentRelationship", "void SecondaryContentRelationship.PrepareForCurveUpdate()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Apply()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Internal.SecondaryContentRelationship", "void SecondaryContentRelationship.Apply()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Remove()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Internal.SecondaryContentRelationship", "void SecondaryContentRelationship.Remove()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void UpdateDependencyProperties()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Internal.SecondaryContentRelationship", "void SecondaryContentRelationship.UpdateDependencyProperties()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Internal.SecondaryContentRelationship CreateStickyHeaderRelationship( global::Microsoft.UI.Xaml.UIElement scrollViewer,  global::Microsoft.UI.Xaml.UIElement panelObject,  global::Microsoft.UI.Xaml.DependencyObject panelTransform,  global::Microsoft.UI.Xaml.DependencyObject headerTransform,  double groupTopY,  double groupBottomY,  double headerHeight)
		{
			throw new global::System.NotImplementedException("The member SecondaryContentRelationship SecondaryContentRelationship.CreateStickyHeaderRelationship(UIElement scrollViewer, UIElement panelObject, DependencyObject panelTransform, DependencyObject headerTransform, double groupTopY, double groupBottomY, double headerHeight) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Internal.SecondaryContentRelationship CreateClipTransformRelationship( global::Microsoft.UI.Xaml.UIElement scrollViewer,  global::Microsoft.UI.Xaml.UIElement clipOwner,  global::Microsoft.UI.Xaml.DependencyObject clipTransform,  double listExtentHeight,  double listViewportHeight)
		{
			throw new global::System.NotImplementedException("The member SecondaryContentRelationship SecondaryContentRelationship.CreateClipTransformRelationship(UIElement scrollViewer, UIElement clipOwner, DependencyObject clipTransform, double listExtentHeight, double listViewportHeight) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Internal.SecondaryContentRelationship CreateParallaxRelationship( global::Microsoft.UI.Xaml.UIElement scrollViewer,  global::Microsoft.UI.Xaml.UIElement headerObject,  global::Microsoft.UI.Xaml.DependencyObject headerTransform,  double[] primaryOffsets,  double[] secondaryOffsets)
		{
			throw new global::System.NotImplementedException("The member SecondaryContentRelationship SecondaryContentRelationship.CreateParallaxRelationship(UIElement scrollViewer, UIElement headerObject, DependencyObject headerTransform, double[] primaryOffsets, double[] secondaryOffsets) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Internal.SecondaryContentRelationship CreateStaticElementRelationship( global::Microsoft.UI.Xaml.UIElement scrollViewer,  global::Microsoft.UI.Xaml.UIElement staticElement,  global::Microsoft.UI.Xaml.DependencyObject elementTransform,  bool isHorizontallyStatic,  bool isInverted)
		{
			throw new global::System.NotImplementedException("The member SecondaryContentRelationship SecondaryContentRelationship.CreateStaticElementRelationship(UIElement scrollViewer, UIElement staticElement, DependencyObject elementTransform, bool isHorizontallyStatic, bool isInverted) is not implemented in Uno.");
		}
		#endif
	}
}
