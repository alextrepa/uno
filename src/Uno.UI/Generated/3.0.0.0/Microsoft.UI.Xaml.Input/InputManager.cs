#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InputManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Input.LastInputDeviceType GetLastInputDeviceType()
		{
			throw new global::System.NotImplementedException("The member LastInputDeviceType InputManager.GetLastInputDeviceType() is not implemented in Uno.");
		}
		#endif
	}
}
