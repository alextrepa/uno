#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InteractionTrackerIdleStateEnteredArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int RequestId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int InteractionTrackerIdleStateEnteredArgs.RequestId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsFromBinding
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool InteractionTrackerIdleStateEnteredArgs.IsFromBinding is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerIdleStateEnteredArgs.RequestId.get
		// Forced skipping of method Microsoft.UI.Composition.Interactions.InteractionTrackerIdleStateEnteredArgs.IsFromBinding.get
	}
}