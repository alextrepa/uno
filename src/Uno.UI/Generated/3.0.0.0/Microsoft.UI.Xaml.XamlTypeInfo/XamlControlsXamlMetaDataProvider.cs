#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.XamlTypeInfo
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlControlsXamlMetaDataProvider : global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public XamlControlsXamlMetaDataProvider() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.XamlTypeInfo.XamlControlsXamlMetaDataProvider", "XamlControlsXamlMetaDataProvider.XamlControlsXamlMetaDataProvider()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.XamlTypeInfo.XamlControlsXamlMetaDataProvider.XamlControlsXamlMetaDataProvider()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Markup.IXamlType GetXamlType( global::System.Type type)
		{
			throw new global::System.NotImplementedException("The member IXamlType XamlControlsXamlMetaDataProvider.GetXamlType(Type type) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Markup.IXamlType GetXamlType( string fullName)
		{
			throw new global::System.NotImplementedException("The member IXamlType XamlControlsXamlMetaDataProvider.GetXamlType(string fullName) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
		{
			throw new global::System.NotImplementedException("The member XmlnsDefinition[] XamlControlsXamlMetaDataProvider.GetXmlnsDefinitions() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void Initialize()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.XamlTypeInfo.XamlControlsXamlMetaDataProvider", "void XamlControlsXamlMetaDataProvider.Initialize()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Markup.IXamlMetadataProvider
	}
}