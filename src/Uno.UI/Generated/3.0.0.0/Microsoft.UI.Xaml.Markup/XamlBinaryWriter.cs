#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Markup
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlBinaryWriter 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Markup.XamlBinaryWriterErrorInformation Write( global::System.Collections.Generic.IList<global::Windows.Storage.Streams.IRandomAccessStream> inputStreams,  global::System.Collections.Generic.IList<global::Windows.Storage.Streams.IRandomAccessStream> outputStreams,  global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider xamlMetadataProvider)
		{
			throw new global::System.NotImplementedException("The member XamlBinaryWriterErrorInformation XamlBinaryWriter.Write(IList<IRandomAccessStream> inputStreams, IList<IRandomAccessStream> outputStreams, IXamlMetadataProvider xamlMetadataProvider) is not implemented in Uno.");
		}
		#endif
	}
}