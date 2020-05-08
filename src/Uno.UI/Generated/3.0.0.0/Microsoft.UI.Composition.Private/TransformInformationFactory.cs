#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class TransformInformationFactory : global::Microsoft.UI.Composition.Private.ITransformInformationFactory
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Composition.Private.TransformInformation ActivateInstance( long hwnd)
		{
			throw new global::System.NotImplementedException("The member TransformInformation TransformInformationFactory.ActivateInstance(long hwnd) is not implemented in Uno.");
		}
		#endif
		// Processing: Microsoft.UI.Composition.Private.ITransformInformationFactory
	}
}
