#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.CustomAttributes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MUXHasCustomActivationFactoryAttribute : global::System.Attribute
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MUXHasCustomActivationFactoryAttribute() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.CustomAttributes.MUXHasCustomActivationFactoryAttribute", "MUXHasCustomActivationFactoryAttribute.MUXHasCustomActivationFactoryAttribute()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.CustomAttributes.MUXHasCustomActivationFactoryAttribute.MUXHasCustomActivationFactoryAttribute()
	}
}
