#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GravityConnectedAnimationConfiguration : global::Microsoft.UI.Xaml.Media.Animation.ConnectedAnimationConfiguration
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public GravityConnectedAnimationConfiguration() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.GravityConnectedAnimationConfiguration", "GravityConnectedAnimationConfiguration.GravityConnectedAnimationConfiguration()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.GravityConnectedAnimationConfiguration.GravityConnectedAnimationConfiguration()
	}
}