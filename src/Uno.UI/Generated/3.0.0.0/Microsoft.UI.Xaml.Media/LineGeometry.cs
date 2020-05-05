#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LineGeometry : global::Microsoft.UI.Xaml.Media.Geometry
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point StartPoint
		{
			get
			{
				return (global::Windows.Foundation.Point)this.GetValue(StartPointProperty);
			}
			set
			{
				this.SetValue(StartPointProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point EndPoint
		{
			get
			{
				return (global::Windows.Foundation.Point)this.GetValue(EndPointProperty);
			}
			set
			{
				this.SetValue(EndPointProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty EndPointProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"EndPoint", typeof(global::Windows.Foundation.Point), 
			typeof(global::Microsoft.UI.Xaml.Media.LineGeometry), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Point)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty StartPointProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"StartPoint", typeof(global::Windows.Foundation.Point), 
			typeof(global::Microsoft.UI.Xaml.Media.LineGeometry), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Point)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public LineGeometry() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.LineGeometry", "LineGeometry.LineGeometry()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.LineGeometry.LineGeometry()
		// Forced skipping of method Microsoft.UI.Xaml.Media.LineGeometry.StartPoint.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.LineGeometry.StartPoint.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.LineGeometry.EndPoint.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.LineGeometry.EndPoint.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.LineGeometry.StartPointProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.LineGeometry.EndPointProperty.get
	}
}