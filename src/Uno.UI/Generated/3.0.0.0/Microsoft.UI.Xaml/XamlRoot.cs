#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlRoot 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Content
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement XamlRoot.Content is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsHostVisible
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool XamlRoot.IsHostVisible is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RasterizationScale
		{
			get
			{
				throw new global::System.NotImplementedException("The member double XamlRoot.RasterizationScale is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Size Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size XamlRoot.Size is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.UIContext UIContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIContext XamlRoot.UIContext is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.XamlRoot.Content.get
		// Forced skipping of method Microsoft.UI.Xaml.XamlRoot.Size.get
		// Forced skipping of method Microsoft.UI.Xaml.XamlRoot.RasterizationScale.get
		// Forced skipping of method Microsoft.UI.Xaml.XamlRoot.IsHostVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.XamlRoot.UIContext.get
		// Forced skipping of method Microsoft.UI.Xaml.XamlRoot.Changed.add
		// Forced skipping of method Microsoft.UI.Xaml.XamlRoot.Changed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.XamlRoot, global::Microsoft.UI.Xaml.XamlRootChangedEventArgs> Changed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.XamlRoot", "event TypedEventHandler<XamlRoot, XamlRootChangedEventArgs> XamlRoot.Changed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.XamlRoot", "event TypedEventHandler<XamlRoot, XamlRootChangedEventArgs> XamlRoot.Changed");
			}
		}
		#endif
	}
}
