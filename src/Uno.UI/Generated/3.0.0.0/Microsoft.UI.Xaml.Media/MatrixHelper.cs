#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MatrixHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Media.Matrix Identity
		{
			get
			{
				throw new global::System.NotImplementedException("The member Matrix MatrixHelper.Identity is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.MatrixHelper.Identity.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Media.Matrix FromElements( double m11,  double m12,  double m21,  double m22,  double offsetX,  double offsetY)
		{
			throw new global::System.NotImplementedException("The member Matrix MatrixHelper.FromElements(double m11, double m12, double m21, double m22, double offsetX, double offsetY) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool GetIsIdentity( global::Microsoft.UI.Xaml.Media.Matrix target)
		{
			throw new global::System.NotImplementedException("The member bool MatrixHelper.GetIsIdentity(Matrix target) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.Point Transform( global::Microsoft.UI.Xaml.Media.Matrix target,  global::Windows.Foundation.Point point)
		{
			throw new global::System.NotImplementedException("The member Point MatrixHelper.Transform(Matrix target, Point point) is not implemented in Uno.");
		}
		#endif
	}
}
