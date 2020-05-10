#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Hosting
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DesignerAppView : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string AppUserModelId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string DesignerAppView.AppUserModelId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int ApplicationViewId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int DesignerAppView.ApplicationViewId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Size ViewSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size DesignerAppView.ViewSize is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Hosting.DesignerAppViewState ViewState
		{
			get
			{
				throw new global::System.NotImplementedException("The member DesignerAppViewState DesignerAppView.ViewState is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.DesignerAppView.ApplicationViewId.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.DesignerAppView.AppUserModelId.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.DesignerAppView.ViewState.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.DesignerAppView.ViewSize.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncAction UpdateViewAsync( global::Microsoft.UI.Xaml.Hosting.DesignerAppViewState viewState,  global::Windows.Foundation.Size viewSize)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction DesignerAppView.UpdateViewAsync(DesignerAppViewState viewState, Size viewSize) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.DesignerAppView", "void DesignerAppView.Dispose()");
		}
		#endif
		// Processing: System.IDisposable
	}
}
