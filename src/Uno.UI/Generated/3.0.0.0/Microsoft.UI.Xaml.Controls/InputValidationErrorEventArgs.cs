#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InputValidationErrorEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationErrorEventAction Action
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputValidationErrorEventAction InputValidationErrorEventArgs.Action is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationError Error
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputValidationError InputValidationErrorEventArgs.Error is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InputValidationErrorEventArgs.Action.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InputValidationErrorEventArgs.Error.get
	}
}