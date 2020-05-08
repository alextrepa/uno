#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemsRepeaterElementPreparedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Element
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ItemsRepeaterElementPreparedEventArgs.Element is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int Index
		{
			get
			{
				throw new global::System.NotImplementedException("The member int ItemsRepeaterElementPreparedEventArgs.Index is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeaterElementPreparedEventArgs.Element.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeaterElementPreparedEventArgs.Index.get
	}
}
