#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IInputValidationControl2 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.InputValidationCommand ValidationCommand
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl2.ValidationCommand.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl2.ValidationCommand.set
	}
}
