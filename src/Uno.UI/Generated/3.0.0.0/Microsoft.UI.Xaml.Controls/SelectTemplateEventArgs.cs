#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SelectTemplateEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string TemplateKey
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SelectTemplateEventArgs.TemplateKey is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SelectTemplateEventArgs", "string SelectTemplateEventArgs.TemplateKey");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object DataContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member object SelectTemplateEventArgs.DataContext is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Owner
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement SelectTemplateEventArgs.Owner is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SelectTemplateEventArgs.TemplateKey.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SelectTemplateEventArgs.TemplateKey.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SelectTemplateEventArgs.DataContext.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SelectTemplateEventArgs.Owner.get
	}
}
