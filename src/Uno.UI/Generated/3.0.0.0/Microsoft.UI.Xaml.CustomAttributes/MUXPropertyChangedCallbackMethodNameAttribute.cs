#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.CustomAttributes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MUXPropertyChangedCallbackMethodNameAttribute : global::System.Attribute
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MUXPropertyChangedCallbackMethodNameAttribute() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.CustomAttributes.MUXPropertyChangedCallbackMethodNameAttribute", "MUXPropertyChangedCallbackMethodNameAttribute.MUXPropertyChangedCallbackMethodNameAttribute()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.CustomAttributes.MUXPropertyChangedCallbackMethodNameAttribute.MUXPropertyChangedCallbackMethodNameAttribute()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  string value;
		#endif
	}
}