#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void UnhandledExceptionEventHandler(object @sender, global::Microsoft.UI.Xaml.UnhandledExceptionEventArgs @e);
	#endif
}