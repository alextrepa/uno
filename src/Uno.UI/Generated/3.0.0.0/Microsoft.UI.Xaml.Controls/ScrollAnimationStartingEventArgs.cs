#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollAnimationStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.CompositionAnimation Animation
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionAnimation ScrollAnimationStartingEventArgs.Animation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollAnimationStartingEventArgs", "CompositionAnimation ScrollAnimationStartingEventArgs.Animation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 EndPosition
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 ScrollAnimationStartingEventArgs.EndPosition is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ScrollInfo ScrollInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollInfo ScrollAnimationStartingEventArgs.ScrollInfo is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 StartPosition
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 ScrollAnimationStartingEventArgs.StartPosition is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollAnimationStartingEventArgs.Animation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollAnimationStartingEventArgs.Animation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollAnimationStartingEventArgs.StartPosition.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollAnimationStartingEventArgs.EndPosition.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollAnimationStartingEventArgs.ScrollInfo.get
	}
}
