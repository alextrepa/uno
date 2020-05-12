#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AutoSuggestBoxHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeepInteriorCornersSquareProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"KeepInteriorCornersSquare", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.AutoSuggestBoxHelper), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.AutoSuggestBoxHelper.KeepInteriorCornersSquareProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetKeepInteriorCornersSquare( global::Microsoft.UI.Xaml.Controls.AutoSuggestBox autoSuggestBox,  bool value)
		{
			autoSuggestBox.SetValue(KeepInteriorCornersSquareProperty, value);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool GetKeepInteriorCornersSquare( global::Microsoft.UI.Xaml.Controls.AutoSuggestBox autoSuggestBox)
		{
			return (bool)autoSuggestBox.GetValue(KeepInteriorCornersSquareProperty);
		}
		#endif
	}
}