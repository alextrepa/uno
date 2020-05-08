#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollerBringingIntoViewEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.SnapPointsMode SnapPointsMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member SnapPointsMode ScrollerBringingIntoViewEventArgs.SnapPointsMode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs", "SnapPointsMode ScrollerBringingIntoViewEventArgs.SnapPointsMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ScrollerBringingIntoViewEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs", "bool ScrollerBringingIntoViewEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.BringIntoViewRequestedEventArgs RequestEventArgs
		{
			get
			{
				throw new global::System.NotImplementedException("The member BringIntoViewRequestedEventArgs ScrollerBringingIntoViewEventArgs.RequestEventArgs is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo ScrollInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollInfo ScrollerBringingIntoViewEventArgs.ScrollInfo is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double TargetHorizontalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollerBringingIntoViewEventArgs.TargetHorizontalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double TargetVerticalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollerBringingIntoViewEventArgs.TargetVerticalOffset is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs.SnapPointsMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs.SnapPointsMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs.RequestEventArgs.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs.TargetHorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs.TargetVerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs.ScrollInfo.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs.Cancel.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollerBringingIntoViewEventArgs.Cancel.set
	}
}
