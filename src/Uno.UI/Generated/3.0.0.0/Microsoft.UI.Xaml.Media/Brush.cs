#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Brush : global::Microsoft.UI.Xaml.DependencyObject,global::Microsoft.UI.Composition.IAnimationObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Transform Transform
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Transform)this.GetValue(TransformProperty);
			}
			set
			{
				this.SetValue(TransformProperty, value);
			}
		}
		#endif
		// Skipping already declared property RelativeTransform
		// Skipping already declared property Opacity
		// Skipping already declared property OpacityProperty
		// Skipping already declared property RelativeTransformProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TransformProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Transform), typeof(global::Microsoft.UI.Xaml.Media.Transform), 
			typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Transform)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Media.Brush.Brush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.Brush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.Opacity.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.Opacity.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.Transform.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.Transform.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.RelativeTransform.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.RelativeTransform.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void PopulatePropertyInfoOverride( string propertyName,  global::Microsoft.UI.Composition.AnimationPropertyInfo animationPropertyInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Brush", "void Brush.PopulatePropertyInfoOverride(string propertyName, AnimationPropertyInfo animationPropertyInfo)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PopulatePropertyInfo( string propertyName,  global::Microsoft.UI.Composition.AnimationPropertyInfo propertyInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Brush", "void Brush.PopulatePropertyInfo(string propertyName, AnimationPropertyInfo propertyInfo)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.OpacityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.TransformProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Brush.RelativeTransformProperty.get
		// Processing: Microsoft.UI.Composition.IAnimationObject
	}
}
