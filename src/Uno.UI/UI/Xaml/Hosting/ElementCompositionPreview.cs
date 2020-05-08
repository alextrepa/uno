#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Hosting
{
    public partial class ElementCompositionPreview
    {
        public static global::Microsoft.UI.Composition.Visual GetElementVisual(global::Microsoft.UI.Xaml.UIElement element)
        {
            return new Microsoft.UI.Composition.Visual() { NativeOwner = element };
        }

        public static void SetElementChildVisual(global::Microsoft.UI.Xaml.UIElement element, global::Microsoft.UI.Composition.Visual visual)
        {
#if __IOS__
            element.Layer.AddSublayer(visual.NativeLayer);
            visual.NativeOwner = element;
            element.ClipsToBounds = false;
            (element as FrameworkElement).SizeChanged += 
                (s, e) => visual.NativeLayer.Frame = new CoreGraphics.CGRect(0, 0, element.Frame.Width, element.Frame.Height);
#endif
        }
    }
}
