#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITextBoxPriv2 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsDesktopPopupMenuEnabled
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool PreventEditFocusLoss
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ITextBoxPriv2.IsDesktopPopupMenuEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ITextBoxPriv2.IsDesktopPopupMenuEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ITextBoxPriv2.PreventEditFocusLoss.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ITextBoxPriv2.PreventEditFocusLoss.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void ForceEditFocusLoss();
		#endif
	}
}
