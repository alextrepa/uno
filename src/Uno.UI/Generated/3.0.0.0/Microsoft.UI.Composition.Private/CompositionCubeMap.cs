#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Private
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionCubeMap 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AutomaticMipmaps
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CompositionCubeMap.AutomaticMipmaps is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint MipLevels
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CompositionCubeMap.MipLevels is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CompositionCubeMap.Size is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Private.CompositionCubeMap.MipLevels.get
		// Forced skipping of method Microsoft.UI.Composition.Private.CompositionCubeMap.Size.get
		// Forced skipping of method Microsoft.UI.Composition.Private.CompositionCubeMap.AutomaticMipmaps.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetSurfaces( uint mipLevel,  global::Microsoft.UI.Composition.ICompositionSurface xPositive,  global::Microsoft.UI.Composition.ICompositionSurface xNegative,  global::Microsoft.UI.Composition.ICompositionSurface yPositive,  global::Microsoft.UI.Composition.ICompositionSurface yNegative,  global::Microsoft.UI.Composition.ICompositionSurface zPositive,  global::Microsoft.UI.Composition.ICompositionSurface zNegative)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Private.CompositionCubeMap", "void CompositionCubeMap.SetSurfaces(uint mipLevel, ICompositionSurface xPositive, ICompositionSurface xNegative, ICompositionSurface yPositive, ICompositionSurface yNegative, ICompositionSurface zPositive, ICompositionSurface zNegative)");
		}
		#endif
	}
}
