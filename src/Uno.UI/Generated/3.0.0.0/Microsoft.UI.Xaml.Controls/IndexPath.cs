#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class IndexPath : global::Windows.Foundation.IStringable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int GetSize()
		{
			throw new global::System.NotImplementedException("The member int IndexPath.GetSize() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int GetAt( int index)
		{
			throw new global::System.NotImplementedException("The member int IndexPath.GetAt(int index) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int CompareTo( global::Microsoft.UI.Xaml.Controls.IndexPath other)
		{
			throw new global::System.NotImplementedException("The member int IndexPath.CompareTo(IndexPath other) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string IndexPath.ToString() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Controls.IndexPath CreateFrom( int index)
		{
			throw new global::System.NotImplementedException("The member IndexPath IndexPath.CreateFrom(int index) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Controls.IndexPath CreateFrom( int groupIndex,  int itemIndex)
		{
			throw new global::System.NotImplementedException("The member IndexPath IndexPath.CreateFrom(int groupIndex, int itemIndex) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Controls.IndexPath CreateFromIndices( global::System.Collections.Generic.IList<int> indices)
		{
			throw new global::System.NotImplementedException("The member IndexPath IndexPath.CreateFromIndices(IList<int> indices) is not implemented in Uno.");
		}
		#endif
	}
}
