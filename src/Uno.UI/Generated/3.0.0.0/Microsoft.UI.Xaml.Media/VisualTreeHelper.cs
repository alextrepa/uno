#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class VisualTreeHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::System.Collections.Generic.IReadOnlyList<global::Microsoft.UI.Xaml.Controls.Primitives.Popup> GetOpenPopupsForXamlRoot( global::Microsoft.UI.Xaml.XamlRoot xamlRoot)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<Popup> VisualTreeHelper.GetOpenPopupsForXamlRoot(XamlRoot xamlRoot) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.GetOpenPopups(Microsoft.UI.Xaml.Window)
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates(Windows.Foundation.Point, Microsoft.UI.Xaml.UIElement)
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates(Windows.Foundation.Rect, Microsoft.UI.Xaml.UIElement)
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates(Windows.Foundation.Point, Microsoft.UI.Xaml.UIElement, bool)
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates(Windows.Foundation.Rect, Microsoft.UI.Xaml.UIElement, bool)
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.GetChild(Microsoft.UI.Xaml.DependencyObject, int)
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.GetChildrenCount(Microsoft.UI.Xaml.DependencyObject)
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.GetParent(Microsoft.UI.Xaml.DependencyObject)
		// Skipping already declared method Microsoft.UI.Xaml.Media.VisualTreeHelper.DisconnectChildrenRecursive(Microsoft.UI.Xaml.UIElement)
	}
}
