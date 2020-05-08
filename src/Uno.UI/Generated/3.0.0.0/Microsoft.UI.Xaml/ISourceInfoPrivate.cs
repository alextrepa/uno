#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ISourceInfoPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		int Column
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		int Line
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		string ParseUri
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		string XbfHash
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.ISourceInfoPrivate.Line.get
		// Forced skipping of method Microsoft.UI.Xaml.ISourceInfoPrivate.Line.set
		// Forced skipping of method Microsoft.UI.Xaml.ISourceInfoPrivate.Column.get
		// Forced skipping of method Microsoft.UI.Xaml.ISourceInfoPrivate.Column.set
		// Forced skipping of method Microsoft.UI.Xaml.ISourceInfoPrivate.ParseUri.get
		// Forced skipping of method Microsoft.UI.Xaml.ISourceInfoPrivate.ParseUri.set
		// Forced skipping of method Microsoft.UI.Xaml.ISourceInfoPrivate.XbfHash.get
		// Forced skipping of method Microsoft.UI.Xaml.ISourceInfoPrivate.XbfHash.set
	}
}
