#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ElementFactory : global::Microsoft.UI.Xaml.DependencyObject,global::Microsoft.UI.Xaml.Controls.IElementFactoryShim
	{
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public ElementFactory() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactory", "ElementFactory.ElementFactory()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactory.ElementFactory()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Microsoft.UI.Xaml.UIElement GetElementCore( global::Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs args)
		{
			throw new global::System.NotImplementedException("The member UIElement ElementFactory.GetElementCore(ElementFactoryGetArgs args) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void RecycleElementCore( global::Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactory", "void ElementFactory.RecycleElementCore(ElementFactoryRecycleArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement GetElement( global::Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs args)
		{
			throw new global::System.NotImplementedException("The member UIElement ElementFactory.GetElement(ElementFactoryGetArgs args) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RecycleElement( global::Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactory", "void ElementFactory.RecycleElement(ElementFactoryRecycleArgs args)");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Controls.IElementFactoryShim
	}
}
