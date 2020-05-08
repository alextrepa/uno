#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlControlsResources : global::Microsoft.UI.Xaml.ResourceDictionary
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool UseCompactResources
		{
			get
			{
				return (bool)this.GetValue(UseCompactResourcesProperty);
			}
			set
			{
				this.SetValue(UseCompactResourcesProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty UseCompactResourcesProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(UseCompactResources), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.XamlControlsResources), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public XamlControlsResources() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.XamlControlsResources", "XamlControlsResources.XamlControlsResources()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.XamlControlsResources.XamlControlsResources()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.XamlControlsResources.UseCompactResources.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.XamlControlsResources.UseCompactResources.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void EnsureRevealLights( global::Microsoft.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.XamlControlsResources", "void XamlControlsResources.EnsureRevealLights(UIElement element)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.XamlControlsResources.UseCompactResourcesProperty.get
	}
}
