#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PropertyMetadata 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.CreateDefaultValueCallback CreateDefaultValueCallback
		{
			get
			{
				throw new global::System.NotImplementedException("The member CreateDefaultValueCallback PropertyMetadata.CreateDefaultValueCallback is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property DefaultValue
		// Skipping already declared method Microsoft.UI.Xaml.PropertyMetadata.PropertyMetadata(object)
		// Forced skipping of method Microsoft.UI.Xaml.PropertyMetadata.PropertyMetadata(object)
		// Skipping already declared method Microsoft.UI.Xaml.PropertyMetadata.PropertyMetadata(object, Microsoft.UI.Xaml.PropertyChangedCallback)
		// Forced skipping of method Microsoft.UI.Xaml.PropertyMetadata.PropertyMetadata(object, Microsoft.UI.Xaml.PropertyChangedCallback)
		// Forced skipping of method Microsoft.UI.Xaml.PropertyMetadata.DefaultValue.get
		// Forced skipping of method Microsoft.UI.Xaml.PropertyMetadata.CreateDefaultValueCallback.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.PropertyMetadata Create( object defaultValue)
		{
			throw new global::System.NotImplementedException("The member PropertyMetadata PropertyMetadata.Create(object defaultValue) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.PropertyMetadata Create( object defaultValue,  global::Microsoft.UI.Xaml.PropertyChangedCallback propertyChangedCallback)
		{
			throw new global::System.NotImplementedException("The member PropertyMetadata PropertyMetadata.Create(object defaultValue, PropertyChangedCallback propertyChangedCallback) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.PropertyMetadata Create( global::Microsoft.UI.Xaml.CreateDefaultValueCallback createDefaultValueCallback)
		{
			throw new global::System.NotImplementedException("The member PropertyMetadata PropertyMetadata.Create(CreateDefaultValueCallback createDefaultValueCallback) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.PropertyMetadata Create( global::Microsoft.UI.Xaml.CreateDefaultValueCallback createDefaultValueCallback,  global::Microsoft.UI.Xaml.PropertyChangedCallback propertyChangedCallback)
		{
			throw new global::System.NotImplementedException("The member PropertyMetadata PropertyMetadata.Create(CreateDefaultValueCallback createDefaultValueCallback, PropertyChangedCallback propertyChangedCallback) is not implemented in Uno.");
		}
		#endif
	}
}