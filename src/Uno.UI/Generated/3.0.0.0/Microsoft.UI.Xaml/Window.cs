#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Window 
	{
		// Skipping already declared property Content
		// Skipping already declared property Bounds
		// Skipping already declared property CoreWindow
		// Skipping already declared property Dispatcher
		// Skipping already declared property Visible
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Compositor Compositor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Compositor Window.Compositor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.UIContext UIContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIContext Window.UIContext is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property Current
		// Forced skipping of method Microsoft.UI.Xaml.Window.Bounds.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Visible.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Content.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Content.set
		// Forced skipping of method Microsoft.UI.Xaml.Window.CoreWindow.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Dispatcher.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Activated.add
		// Forced skipping of method Microsoft.UI.Xaml.Window.Activated.remove
		// Forced skipping of method Microsoft.UI.Xaml.Window.Closed.add
		// Forced skipping of method Microsoft.UI.Xaml.Window.Closed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Window.SizeChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Window.SizeChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Window.VisibilityChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Window.VisibilityChanged.remove
		// Skipping already declared method Microsoft.UI.Xaml.Window.Activate()
		// Skipping already declared method Microsoft.UI.Xaml.Window.Close()
		// Forced skipping of method Microsoft.UI.Xaml.Window.Compositor.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.UIContext.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Current.get
		// Skipping already declared event Microsoft.UI.Xaml.Window.Activated
		// Skipping already declared event Microsoft.UI.Xaml.Window.Closed
		// Skipping already declared event Microsoft.UI.Xaml.Window.SizeChanged
		// Skipping already declared event Microsoft.UI.Xaml.Window.VisibilityChanged
	}
}