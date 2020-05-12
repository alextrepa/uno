#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IScrollAnchorProvider 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.UIElement CurrentAnchor
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IScrollAnchorProvider.CurrentAnchor.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void RegisterAnchorCandidate( global::Microsoft.UI.Xaml.UIElement element);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void UnregisterAnchorCandidate( global::Microsoft.UI.Xaml.UIElement element);
		#endif
	}
}