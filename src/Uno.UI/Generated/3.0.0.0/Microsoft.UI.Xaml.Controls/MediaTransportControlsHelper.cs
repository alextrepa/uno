#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaTransportControlsHelper 
	{
		#if false || false || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DropoutOrderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"DropoutOrder", typeof(int?), 
			typeof(global::Microsoft.UI.Xaml.Controls.MediaTransportControlsHelper), 
			new FrameworkPropertyMetadata(default(int?)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.MediaTransportControlsHelper.DropoutOrderProperty.get
		#if false || false || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static int? GetDropoutOrder( global::Microsoft.UI.Xaml.UIElement element)
		{
			return (int?)element.GetValue(DropoutOrderProperty);
		}
		#endif
		#if false || false || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetDropoutOrder( global::Microsoft.UI.Xaml.UIElement element,  int? value)
		{
			element.SetValue(DropoutOrderProperty, value);
		}
		#endif
	}
}