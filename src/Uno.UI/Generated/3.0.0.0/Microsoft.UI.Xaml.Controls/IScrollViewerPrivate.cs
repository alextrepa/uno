#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IScrollViewerPrivate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool ArePointerWheelEventsIgnored
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsInActiveDirectManipulation
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsInDirectManipulation
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		bool IsRequestBringIntoViewIgnored
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IScrollViewerPrivate.IsInDirectManipulation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IScrollViewerPrivate.ArePointerWheelEventsIgnored.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IScrollViewerPrivate.ArePointerWheelEventsIgnored.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IScrollViewerPrivate.IsRequestBringIntoViewIgnored.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IScrollViewerPrivate.IsRequestBringIntoViewIgnored.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IScrollViewerPrivate.IsInActiveDirectManipulation.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void DisableOverpan();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void EnableOverpan();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		void SetIsNearVerticalAlignmentForced( bool enabled);
		#endif
	}
}
