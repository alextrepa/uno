#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Internal
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LayoutTransitionElementUtilities 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.UIElement CreateLayoutTransitionElement( global::Microsoft.UI.Xaml.UIElement source,  global::Microsoft.UI.Xaml.UIElement parent)
		{
			throw new global::System.NotImplementedException("The member UIElement LayoutTransitionElementUtilities.CreateLayoutTransitionElement(UIElement source, UIElement parent) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void DestroyLayoutTransitionElement( global::Microsoft.UI.Xaml.UIElement source,  global::Microsoft.UI.Xaml.UIElement parent,  global::Microsoft.UI.Xaml.UIElement layoutTransitionElement)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Internal.LayoutTransitionElementUtilities", "void LayoutTransitionElementUtilities.DestroyLayoutTransitionElement(UIElement source, UIElement parent, UIElement layoutTransitionElement)");
		}
		#endif
	}
}
