#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IFindNextElementOptionsPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IgnoreOcclusivity
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Input.IFindNextElementOptionsPrivate.IgnoreOcclusivity.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.IFindNextElementOptionsPrivate.IgnoreOcclusivity.set
	}
}
