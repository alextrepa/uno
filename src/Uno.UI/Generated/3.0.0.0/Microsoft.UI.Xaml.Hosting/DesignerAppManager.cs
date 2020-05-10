#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Hosting
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DesignerAppManager : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string AppUserModelId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string DesignerAppManager.AppUserModelId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public DesignerAppManager( string appUserModelId) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.DesignerAppManager", "DesignerAppManager.DesignerAppManager(string appUserModelId)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.DesignerAppManager.DesignerAppManager(string)
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.DesignerAppManager.AppUserModelId.get
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.DesignerAppManager.DesignerAppExited.add
		// Forced skipping of method Microsoft.UI.Xaml.Hosting.DesignerAppManager.DesignerAppExited.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Microsoft.UI.Xaml.Hosting.DesignerAppView> CreateNewViewAsync( global::Microsoft.UI.Xaml.Hosting.DesignerAppViewState initialViewState,  global::Windows.Foundation.Size initialViewSize)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DesignerAppView> DesignerAppManager.CreateNewViewAsync(DesignerAppViewState initialViewState, Size initialViewSize) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncAction LoadObjectIntoAppAsync( string dllName,  global::System.Guid classId,  string initializationData)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction DesignerAppManager.LoadObjectIntoAppAsync(string dllName, Guid classId, string initializationData) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.DesignerAppManager", "void DesignerAppManager.Dispose()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Hosting.DesignerAppManager, global::Microsoft.UI.Xaml.Hosting.DesignerAppExitedEventArgs> DesignerAppExited
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.DesignerAppManager", "event TypedEventHandler<DesignerAppManager, DesignerAppExitedEventArgs> DesignerAppManager.DesignerAppExited");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Hosting.DesignerAppManager", "event TypedEventHandler<DesignerAppManager, DesignerAppExitedEventArgs> DesignerAppManager.DesignerAppExited");
			}
		}
		#endif
		// Processing: System.IDisposable
	}
}
