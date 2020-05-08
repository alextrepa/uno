#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ZoomAnimationStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionAnimation Animation
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionAnimation ZoomAnimationStartingEventArgs.Animation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ZoomAnimationStartingEventArgs", "CompositionAnimation ZoomAnimationStartingEventArgs.Animation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 CenterPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 ZoomAnimationStartingEventArgs.CenterPoint is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float EndZoomFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ZoomAnimationStartingEventArgs.EndZoomFactor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float StartZoomFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ZoomAnimationStartingEventArgs.StartZoomFactor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ZoomInfo ZoomInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member ZoomInfo ZoomAnimationStartingEventArgs.ZoomInfo is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomAnimationStartingEventArgs.CenterPoint.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomAnimationStartingEventArgs.StartZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomAnimationStartingEventArgs.EndZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomAnimationStartingEventArgs.Animation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomAnimationStartingEventArgs.Animation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ZoomAnimationStartingEventArgs.ZoomInfo.get
	}
}
