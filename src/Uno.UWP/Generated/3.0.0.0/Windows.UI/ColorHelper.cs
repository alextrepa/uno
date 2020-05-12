#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI
{
	public  partial class ColorHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static string ToDisplayName( global::Windows.UI.Color color)
		{
			throw new global::System.NotImplementedException("The member string ColorHelper.ToDisplayName(Color color) is not implemented in Uno.");
		}
		#endif
	}
}
