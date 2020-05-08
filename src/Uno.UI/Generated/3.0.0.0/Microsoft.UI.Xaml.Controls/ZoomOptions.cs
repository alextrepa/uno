#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ZoomOptions 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.SnapPointsMode SnapPointsMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member SnapPointsMode ZoomOptions.SnapPointsMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ZoomOptions", "SnapPointsMode ZoomOptions.SnapPointsMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.AnimationMode AnimationMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member AnimationMode ZoomOptions.AnimationMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ZoomOptions", "AnimationMode ZoomOptions.AnimationMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ZoomOptions( global::Microsoft.UI.Xaml.Controls.AnimationMode animationMode) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ZoomOptions", "ZoomOptions.ZoomOptions(AnimationMode animationMode)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomOptions.ZoomOptions(Microsoft.UI.Xaml.Controls.AnimationMode)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ZoomOptions( global::Microsoft.UI.Xaml.Controls.AnimationMode animationMode,  global::Microsoft.UI.Xaml.Controls.SnapPointsMode snapPointsMode) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ZoomOptions", "ZoomOptions.ZoomOptions(AnimationMode animationMode, SnapPointsMode snapPointsMode)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomOptions.ZoomOptions(Microsoft.UI.Xaml.Controls.AnimationMode, Microsoft.UI.Xaml.Controls.SnapPointsMode)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomOptions.AnimationMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomOptions.AnimationMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomOptions.SnapPointsMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomOptions.SnapPointsMode.set
	}
}
