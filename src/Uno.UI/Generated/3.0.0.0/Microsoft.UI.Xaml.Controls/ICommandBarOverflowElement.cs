#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICommandBarOverflowElement 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool UseOverflowStyle
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ICommandBarOverflowElement.UseOverflowStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ICommandBarOverflowElement.UseOverflowStyle.set
	}
}