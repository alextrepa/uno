#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IElementSoundPlayerStaticsPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void RequestInteractionSoundForElement( global::Microsoft.UI.Xaml.ElementSoundKind sound,  global::Microsoft.UI.Xaml.DependencyObject element);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.ElementSoundMode GetEffectiveSoundMode( global::Microsoft.UI.Xaml.DependencyObject element);
		#endif
	}
}
