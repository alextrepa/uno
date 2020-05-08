#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StackLayout : global::Microsoft.UI.Xaml.Controls.VirtualizingLayout
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Spacing
		{
			get
			{
				return (double)this.GetValue(SpacingProperty);
			}
			set
			{
				this.SetValue(SpacingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Orientation Orientation
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Orientation)this.GetValue(OrientationProperty);
			}
			set
			{
				this.SetValue(OrientationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OrientationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Orientation), typeof(global::Microsoft.UI.Xaml.Controls.Orientation), 
			typeof(global::Microsoft.UI.Xaml.Controls.StackLayout), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Orientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SpacingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Spacing), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.StackLayout), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public StackLayout() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.StackLayout", "StackLayout.StackLayout()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.StackLayout.StackLayout()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.StackLayout.Orientation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.StackLayout.Orientation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.StackLayout.Spacing.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.StackLayout.Spacing.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.StackLayout.OrientationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.StackLayout.SpacingProperty.get
	}
}
