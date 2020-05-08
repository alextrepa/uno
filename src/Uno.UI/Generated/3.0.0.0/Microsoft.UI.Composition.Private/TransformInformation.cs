#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class TransformInformation 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 DisplaySizePhysicalPixels
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 TransformInformation.DisplaySizePhysicalPixels is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 ScreenPhysicalPixelsToHimetricScaleFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 TransformInformation.ScreenPhysicalPixelsToHimetricScaleFactor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector3 VisualRelativePixelsToScreenPhysicalPixelsRotation
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 TransformInformation.VisualRelativePixelsToScreenPhysicalPixelsRotation is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float VisualRelativePixelsToScreenPhysicalPixelsScale
		{
			get
			{
				throw new global::System.NotImplementedException("The member float TransformInformation.VisualRelativePixelsToScreenPhysicalPixelsScale is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TransformInformation( long hwnd) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Private.TransformInformation", "TransformInformation.TransformInformation(long hwnd)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Private.TransformInformation.TransformInformation(long)
		// Forced skipping of method Microsoft.UI.Composition.Private.TransformInformation.DisplaySizePhysicalPixels.get
		// Forced skipping of method Microsoft.UI.Composition.Private.TransformInformation.ScreenPhysicalPixelsToHimetricScaleFactor.get
		// Forced skipping of method Microsoft.UI.Composition.Private.TransformInformation.VisualRelativePixelsToScreenPhysicalPixelsScale.get
		// Forced skipping of method Microsoft.UI.Composition.Private.TransformInformation.VisualRelativePixelsToScreenPhysicalPixelsRotation.get
	}
}
