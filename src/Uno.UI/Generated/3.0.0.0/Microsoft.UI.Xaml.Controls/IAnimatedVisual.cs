#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IAnimatedVisual : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::System.TimeSpan Duration
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Composition.Visual RootVisual
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::System.Numerics.Vector2 Size
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IAnimatedVisual.RootVisual.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IAnimatedVisual.Size.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IAnimatedVisual.Duration.get
	}
}
