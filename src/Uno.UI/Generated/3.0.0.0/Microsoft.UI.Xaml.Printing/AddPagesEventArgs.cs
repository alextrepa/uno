#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Printing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AddPagesEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Graphics.Printing.PrintTaskOptions PrintTaskOptions
		{
			get
			{
				throw new global::System.NotImplementedException("The member PrintTaskOptions AddPagesEventArgs.PrintTaskOptions is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AddPagesEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Printing.AddPagesEventArgs", "AddPagesEventArgs.AddPagesEventArgs()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Printing.AddPagesEventArgs.AddPagesEventArgs()
		// Forced skipping of method Microsoft.UI.Xaml.Printing.AddPagesEventArgs.PrintTaskOptions.get
	}
}