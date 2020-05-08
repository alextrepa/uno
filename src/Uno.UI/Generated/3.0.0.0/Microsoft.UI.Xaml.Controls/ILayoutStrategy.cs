#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ILayoutStrategy 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetLayoutDataInfoProvider( global::Microsoft.UI.Xaml.Controls.ILayoutDataInfoProvider provider);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void BeginMeasure();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void EndMeasure();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Size GetElementMeasureSize( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex,  global::Windows.Foundation.Rect windowConstraint);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Rect GetElementBounds( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex,  global::Windows.Foundation.Size containerDesiredSize,  global::Microsoft.UI.Xaml.Controls.LayoutReference referenceInformation,  global::Windows.Foundation.Rect windowConstraint);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Rect GetElementArrangeBounds( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex,  global::Windows.Foundation.Rect containerBounds,  global::Windows.Foundation.Rect windowConstraint,  global::Windows.Foundation.Size finalSize);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool ShouldContinueFillingUpSpace( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex,  global::Microsoft.UI.Xaml.Controls.LayoutReference referenceInformation,  global::Windows.Foundation.Rect windowToFill);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Point GetPositionOfFirstElement();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.Orientation GetVirtualizationDirection();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		int EstimateElementIndex( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  global::Microsoft.UI.Xaml.Controls.EstimationReference headerReference,  global::Microsoft.UI.Xaml.Controls.EstimationReference containerReference,  global::Windows.Foundation.Rect window, out global::Windows.Foundation.Rect targetRect);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Rect EstimateElementBounds( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex,  global::Microsoft.UI.Xaml.Controls.EstimationReference headerReference,  global::Microsoft.UI.Xaml.Controls.EstimationReference containerReference,  global::Windows.Foundation.Rect window);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Size EstimatePanelExtent( global::Microsoft.UI.Xaml.Controls.EstimationReference lastHeaderReference,  global::Microsoft.UI.Xaml.Controls.EstimationReference lastContainerReference,  global::Windows.Foundation.Rect windowConstraint);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void EstimateIndexFromPoint( bool requestingInsertionIndex,  global::Windows.Foundation.Point point,  global::Microsoft.UI.Xaml.Controls.EstimationReference reference,  global::Windows.Foundation.Rect windowConstraint, out global::Microsoft.UI.Xaml.Controls.IndexSearchHint searchHint, out global::Microsoft.UI.Xaml.Controls.ElementType elementType, out int elementIndex);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void GetTargetIndexFromNavigationAction( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex,  global::Microsoft.UI.Xaml.Controls.KeyNavigationAction action,  global::Windows.Foundation.Rect windowConstraint,  int itemIndexHintForHeaderNavigation, out global::Microsoft.UI.Xaml.Controls.ElementType targetElementType, out int targetElementIndex);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void IsIndexLayoutBoundary( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex,  global::Windows.Foundation.Rect windowConstraint, out bool isLeftBoundary, out bool isTopBoundary, out bool isRightBoundary, out bool isBottomBoundary);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool GetRegularSnapPoints(out float nearOffset, out float farOffset, out float spacing);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool HasIrregularSnapPoints( global::Microsoft.UI.Xaml.Controls.ElementType elementType);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool HasSnapPointOnElement( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool GetIsWrappingStrategy();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Windows.Foundation.Rect GetElementTransitionsBounds( global::Microsoft.UI.Xaml.Controls.ElementType elementType,  int elementIndex,  global::Windows.Foundation.Rect windowConstraint);
		#endif
	}
}
