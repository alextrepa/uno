#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Input
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ManipulationStartingRoutedEventArgs : global::Microsoft.UI.Xaml.RoutedEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Input.ManipulationPivot Pivot
		{
			get
			{
				throw new global::System.NotImplementedException("The member ManipulationPivot ManipulationStartingRoutedEventArgs.Pivot is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs", "ManipulationPivot ManipulationStartingRoutedEventArgs.Pivot");
			}
		}
		#endif
		// Skipping already declared property Mode
		// Skipping already declared property Handled
		// Skipping already declared property Container
		// Skipping already declared method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.ManipulationStartingRoutedEventArgs()
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.ManipulationStartingRoutedEventArgs()
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.Mode.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.Mode.set
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.Container.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.Container.set
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.Pivot.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.Pivot.set
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.Handled.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs.Handled.set
	}
}