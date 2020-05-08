#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DxamlCoreTestHooks 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public DxamlCoreTestHooks() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.DxamlCoreTestHooks", "DxamlCoreTestHooks.DxamlCoreTestHooks()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.DxamlCoreTestHooks.DxamlCoreTestHooks()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DxamlCoreTestHooks GetForCurrentThread()
		{
			throw new global::System.NotImplementedException("The member DxamlCoreTestHooks DxamlCoreTestHooks.GetForCurrentThread() is not implemented in Uno.");
		}
		#endif
	}
}
