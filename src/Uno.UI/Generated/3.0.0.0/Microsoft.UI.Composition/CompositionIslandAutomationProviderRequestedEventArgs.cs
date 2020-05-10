#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionIslandAutomationProviderRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CompositionIslandAutomationProviderRequestedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionIslandAutomationProviderRequestedEventArgs", "bool CompositionIslandAutomationProviderRequestedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object AutomationProvider
		{
			get
			{
				throw new global::System.NotImplementedException("The member object CompositionIslandAutomationProviderRequestedEventArgs.AutomationProvider is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionIslandAutomationProviderRequestedEventArgs", "object CompositionIslandAutomationProviderRequestedEventArgs.AutomationProvider");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionIslandAutomationProviderRequestedEventArgs.AutomationProvider.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionIslandAutomationProviderRequestedEventArgs.AutomationProvider.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionIslandAutomationProviderRequestedEventArgs.Handled.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionIslandAutomationProviderRequestedEventArgs.Handled.set
	}
}
