#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DataSourceReader : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void AddDataSourcePropertyId( string propertyName,  uint dataSourcePropertyId,  global::Microsoft.UI.Composition.Private.AnimationPropertyKind propertyKind)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Private.DataSourceReader", "void DataSourceReader.AddDataSourcePropertyId(string propertyName, uint dataSourcePropertyId, AnimationPropertyKind propertyKind)");
		}
		#endif
	}
}
