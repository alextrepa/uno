#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class LayoutInformation 
	{
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.LayoutInformation.GetAvailableSize(Microsoft.UI.Xaml.UIElement)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.UIElement GetLayoutExceptionElement( object dispatcher)
		{
			throw new global::System.NotImplementedException("The member UIElement LayoutInformation.GetLayoutExceptionElement(object dispatcher) is not implemented in Uno.");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.LayoutInformation.GetLayoutSlot(Microsoft.UI.Xaml.FrameworkElement)
	}
}
