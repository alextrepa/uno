#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ElementFactoryGetArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Parent
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ElementFactoryGetArgs.Parent is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs", "UIElement ElementFactoryGetArgs.Parent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Data
		{
			get
			{
				throw new global::System.NotImplementedException("The member object ElementFactoryGetArgs.Data is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs", "object ElementFactoryGetArgs.Data");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ElementFactoryGetArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs", "ElementFactoryGetArgs.ElementFactoryGetArgs()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs.ElementFactoryGetArgs()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs.Data.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs.Data.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs.Parent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs.Parent.set
	}
}