#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CommandBarFlyout : global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Collections.IObservableVector<global::Microsoft.UI.Xaml.Controls.ICommandBarElement> PrimaryCommands
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<ICommandBarElement> CommandBarFlyout.PrimaryCommands is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Collections.IObservableVector<global::Microsoft.UI.Xaml.Controls.ICommandBarElement> SecondaryCommands
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<ICommandBarElement> CommandBarFlyout.SecondaryCommands is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CommandBarFlyout() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.CommandBarFlyout", "CommandBarFlyout.CommandBarFlyout()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CommandBarFlyout.CommandBarFlyout()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CommandBarFlyout.PrimaryCommands.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CommandBarFlyout.SecondaryCommands.get
	}
}