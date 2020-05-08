#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RecyclingElementFactory : global::Microsoft.UI.Xaml.Controls.ElementFactory
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IDictionary<string, global::Microsoft.UI.Xaml.DataTemplate> Templates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IDictionary<string, DataTemplate> RecyclingElementFactory.Templates is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclingElementFactory", "IDictionary<string, DataTemplate> RecyclingElementFactory.Templates");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.RecyclePool RecyclePool
		{
			get
			{
				throw new global::System.NotImplementedException("The member RecyclePool RecyclingElementFactory.RecyclePool is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclingElementFactory", "RecyclePool RecyclingElementFactory.RecyclePool");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RecyclingElementFactory() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclingElementFactory", "RecyclingElementFactory.RecyclingElementFactory()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclingElementFactory.RecyclingElementFactory()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclingElementFactory.RecyclePool.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclingElementFactory.RecyclePool.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclingElementFactory.Templates.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclingElementFactory.Templates.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclingElementFactory.SelectTemplateKey.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclingElementFactory.SelectTemplateKey.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual string OnSelectTemplateKeyCore( object dataContext,  global::Microsoft.UI.Xaml.UIElement owner)
		{
			throw new global::System.NotImplementedException("The member string RecyclingElementFactory.OnSelectTemplateKeyCore(object dataContext, UIElement owner) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.RecyclingElementFactory, global::Microsoft.UI.Xaml.Controls.SelectTemplateEventArgs> SelectTemplateKey
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclingElementFactory", "event TypedEventHandler<RecyclingElementFactory, SelectTemplateEventArgs> RecyclingElementFactory.SelectTemplateKey");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclingElementFactory", "event TypedEventHandler<RecyclingElementFactory, SelectTemplateEventArgs> RecyclingElementFactory.SelectTemplateKey");
			}
		}
		#endif
	}
}
