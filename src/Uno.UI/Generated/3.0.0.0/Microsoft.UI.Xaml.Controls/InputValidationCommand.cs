#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InputValidationCommand 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationMode InputValidationMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputValidationMode InputValidationCommand.InputValidationMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.InputValidationCommand", "InputValidationMode InputValidationCommand.InputValidationMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationKind InputValidationKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputValidationKind InputValidationCommand.InputValidationKind is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.InputValidationCommand", "InputValidationKind InputValidationCommand.InputValidationKind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InputValidationCommand() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.InputValidationCommand", "InputValidationCommand.InputValidationCommand()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InputValidationCommand.InputValidationCommand()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InputValidationCommand.InputValidationMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InputValidationCommand.InputValidationMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InputValidationCommand.InputValidationKind.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InputValidationCommand.InputValidationKind.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanValidate( global::Microsoft.UI.Xaml.Controls.IInputValidationControl validationControl)
		{
			throw new global::System.NotImplementedException("The member bool InputValidationCommand.CanValidate(IInputValidationControl validationControl) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Validate( global::Microsoft.UI.Xaml.Controls.IInputValidationControl validationControl)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.InputValidationCommand", "void InputValidationCommand.Validate(IInputValidationControl validationControl)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual bool CanValidateCore( global::Microsoft.UI.Xaml.Controls.IInputValidationControl validationControl)
		{
			throw new global::System.NotImplementedException("The member bool InputValidationCommand.CanValidateCore(IInputValidationControl validationControl) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void ValidateCore( global::Microsoft.UI.Xaml.Controls.IInputValidationControl validationControl)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.InputValidationCommand", "void InputValidationCommand.ValidateCore(IInputValidationControl validationControl)");
		}
		#endif
	}
}
