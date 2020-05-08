#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RecyclePool 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PoolInstanceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"PoolInstance", typeof(global::Microsoft.UI.Xaml.Controls.RecyclePool), 
			typeof(global::Microsoft.UI.Xaml.Controls.RecyclePool), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.RecyclePool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RecyclePool() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclePool", "RecyclePool.RecyclePool()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclePool.RecyclePool()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PutElement( global::Microsoft.UI.Xaml.UIElement element,  string key)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclePool", "void RecyclePool.PutElement(UIElement element, string key)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PutElement( global::Microsoft.UI.Xaml.UIElement element,  string key,  global::Microsoft.UI.Xaml.UIElement owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclePool", "void RecyclePool.PutElement(UIElement element, string key, UIElement owner)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement TryGetElement( string key)
		{
			throw new global::System.NotImplementedException("The member UIElement RecyclePool.TryGetElement(string key) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement TryGetElement( string key,  global::Microsoft.UI.Xaml.UIElement owner)
		{
			throw new global::System.NotImplementedException("The member UIElement RecyclePool.TryGetElement(string key, UIElement owner) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void PutElementCore( global::Microsoft.UI.Xaml.UIElement element,  string key,  global::Microsoft.UI.Xaml.UIElement owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RecyclePool", "void RecyclePool.PutElementCore(UIElement element, string key, UIElement owner)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual global::Microsoft.UI.Xaml.UIElement TryGetElementCore( string key,  global::Microsoft.UI.Xaml.UIElement owner)
		{
			throw new global::System.NotImplementedException("The member UIElement RecyclePool.TryGetElementCore(string key, UIElement owner) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RecyclePool.PoolInstanceProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Controls.RecyclePool GetPoolInstance( global::Microsoft.UI.Xaml.DataTemplate dataTemplate)
		{
			return (global::Microsoft.UI.Xaml.Controls.RecyclePool)dataTemplate.GetValue(PoolInstanceProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetPoolInstance( global::Microsoft.UI.Xaml.DataTemplate dataTemplate,  global::Microsoft.UI.Xaml.Controls.RecyclePool value)
		{
			dataTemplate.SetValue(PoolInstanceProperty, value);
		}
		#endif
	}
}
