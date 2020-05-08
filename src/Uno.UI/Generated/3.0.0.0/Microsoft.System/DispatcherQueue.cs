#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.System
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DispatcherQueue 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool HasThreadAccess
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DispatcherQueue.HasThreadAccess is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared method Microsoft.System.DispatcherQueue.CreateTimer()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryEnqueue( global::Microsoft.System.DispatcherQueueHandler callback)
		{
			throw new global::System.NotImplementedException("The member bool DispatcherQueue.TryEnqueue(DispatcherQueueHandler callback) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool TryEnqueue( global::Microsoft.System.DispatcherQueuePriority priority,  global::Microsoft.System.DispatcherQueueHandler callback)
		{
			throw new global::System.NotImplementedException("The member bool DispatcherQueue.TryEnqueue(DispatcherQueuePriority priority, DispatcherQueueHandler callback) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.System.DispatcherQueue.ShutdownStarting.add
		// Forced skipping of method Microsoft.System.DispatcherQueue.ShutdownStarting.remove
		// Forced skipping of method Microsoft.System.DispatcherQueue.ShutdownCompleted.add
		// Forced skipping of method Microsoft.System.DispatcherQueue.ShutdownCompleted.remove
		// Forced skipping of method Microsoft.System.DispatcherQueue.HasThreadAccess.get
		// Skipping already declared method Microsoft.System.DispatcherQueue.GetForCurrentThread()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.System.DispatcherQueue, object> ShutdownCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.System.DispatcherQueue", "event TypedEventHandler<DispatcherQueue, object> DispatcherQueue.ShutdownCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.System.DispatcherQueue", "event TypedEventHandler<DispatcherQueue, object> DispatcherQueue.ShutdownCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.System.DispatcherQueue, global::Microsoft.System.DispatcherQueueShutdownStartingEventArgs> ShutdownStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.System.DispatcherQueue", "event TypedEventHandler<DispatcherQueue, DispatcherQueueShutdownStartingEventArgs> DispatcherQueue.ShutdownStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.System.DispatcherQueue", "event TypedEventHandler<DispatcherQueue, DispatcherQueueShutdownStartingEventArgs> DispatcherQueue.ShutdownStarting");
			}
		}
		#endif
	}
}
