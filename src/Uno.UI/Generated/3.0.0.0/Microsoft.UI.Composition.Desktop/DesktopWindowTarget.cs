#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Desktop
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DesktopWindowTarget : global::Microsoft.UI.Composition.CompositionTarget
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsTopmost
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DesktopWindowTarget.IsTopmost is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Desktop.DesktopWindowTarget.IsTopmost.get
	}
}
