#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class JumpListItemBackgroundConverter : global::Microsoft.UI.Xaml.DependencyObject,global::Microsoft.UI.Xaml.Data.IValueConverter
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush Enabled
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(EnabledProperty);
			}
			set
			{
				this.SetValue(EnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush Disabled
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(DisabledProperty);
			}
			set
			{
				this.SetValue(DisabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DisabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Disabled", typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty EnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Enabled", typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.JumpListItemBackgroundConverter()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.JumpListItemBackgroundConverter()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.Enabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.Enabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.Disabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.Disabled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Convert( object value,  global::System.Type targetType,  object parameter,  string language)
		{
			throw new global::System.NotImplementedException("The member object JumpListItemBackgroundConverter.Convert(object value, Type targetType, object parameter, string language) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ConvertBack( object value,  global::System.Type targetType,  object parameter,  string language)
		{
			throw new global::System.NotImplementedException("The member object JumpListItemBackgroundConverter.ConvertBack(object value, Type targetType, object parameter, string language) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.EnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter.DisabledProperty.get
		// Processing: Microsoft.UI.Xaml.Data.IValueConverter
	}
}