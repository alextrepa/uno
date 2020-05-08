#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class VisualTreeIsland : global::Microsoft.UI.Composition.CompositionIsland
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.VisualCollection Children
		{
			get
			{
				throw new global::System.NotImplementedException("The member VisualCollection VisualTreeIsland.Children is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.VisualTreeIsland.Children.get
	}
}
