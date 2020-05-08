#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IFlyoutBasePrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsLightDismissOverlayEnabled
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool UsePickerFlyoutTheme
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IFlyoutBasePrivate.UsePickerFlyoutTheme.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IFlyoutBasePrivate.UsePickerFlyoutTheme.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IFlyoutBasePrivate.IsLightDismissOverlayEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IFlyoutBasePrivate.IsLightDismissOverlayEnabled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void PlaceFlyoutForDateTimePicker( global::Windows.Foundation.Point point);
		#endif
	}
}
