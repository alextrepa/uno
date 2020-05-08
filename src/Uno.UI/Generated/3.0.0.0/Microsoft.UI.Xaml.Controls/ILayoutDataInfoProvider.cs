#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ILayoutDataInfoProvider 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		int GetTotalItemCount();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		int GetTotalGroupCount();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void GetGroupInformationFromItemIndex( int itemIndex, out int indexOfGroup, out int indexInsideGroup, out int itemCountInGroup);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void GetGroupInformationFromGroupIndex( int groupIndex, out int startItemIndex, out int itemCountInGroup);
		#endif
	}
}
