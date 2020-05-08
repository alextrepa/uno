#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ElementFactoryRecycleArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Parent
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ElementFactoryRecycleArgs.Parent is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs", "UIElement ElementFactoryRecycleArgs.Parent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Element
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ElementFactoryRecycleArgs.Element is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs", "UIElement ElementFactoryRecycleArgs.Element");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ElementFactoryRecycleArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs", "ElementFactoryRecycleArgs.ElementFactoryRecycleArgs()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs.ElementFactoryRecycleArgs()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs.Element.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs.Element.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs.Parent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs.Parent.set
	}
}
