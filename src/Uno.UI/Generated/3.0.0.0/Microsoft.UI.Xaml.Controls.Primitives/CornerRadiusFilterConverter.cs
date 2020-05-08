#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CornerRadiusFilterConverter : global::Microsoft.UI.Xaml.DependencyObject,global::Microsoft.UI.Xaml.Data.IValueConverter
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterKind Filter
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterKind)this.GetValue(FilterProperty);
			}
			set
			{
				this.SetValue(FilterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FilterProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Filter), typeof(global::Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterKind), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public CornerRadiusFilterConverter() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter", "CornerRadiusFilterConverter.CornerRadiusFilterConverter()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter.CornerRadiusFilterConverter()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter.Filter.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter.Filter.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Convert( object value,  global::System.Type targetType,  object parameter,  string language)
		{
			throw new global::System.NotImplementedException("The member object CornerRadiusFilterConverter.Convert(object value, Type targetType, object parameter, string language) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ConvertBack( object value,  global::System.Type targetType,  object parameter,  string language)
		{
			throw new global::System.NotImplementedException("The member object CornerRadiusFilterConverter.ConvertBack(object value, Type targetType, object parameter, string language) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterConverter.FilterProperty.get
		// Processing: Microsoft.UI.Xaml.Data.IValueConverter
	}
}
