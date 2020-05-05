#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PlaneProjection : global::Microsoft.UI.Xaml.Media.Projection
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RotationZ
		{
			get
			{
				return (double)this.GetValue(RotationZProperty);
			}
			set
			{
				this.SetValue(RotationZProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RotationY
		{
			get
			{
				return (double)this.GetValue(RotationYProperty);
			}
			set
			{
				this.SetValue(RotationYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double RotationX
		{
			get
			{
				return (double)this.GetValue(RotationXProperty);
			}
			set
			{
				this.SetValue(RotationXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double LocalOffsetZ
		{
			get
			{
				return (double)this.GetValue(LocalOffsetZProperty);
			}
			set
			{
				this.SetValue(LocalOffsetZProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double LocalOffsetY
		{
			get
			{
				return (double)this.GetValue(LocalOffsetYProperty);
			}
			set
			{
				this.SetValue(LocalOffsetYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double LocalOffsetX
		{
			get
			{
				return (double)this.GetValue(LocalOffsetXProperty);
			}
			set
			{
				this.SetValue(LocalOffsetXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double GlobalOffsetZ
		{
			get
			{
				return (double)this.GetValue(GlobalOffsetZProperty);
			}
			set
			{
				this.SetValue(GlobalOffsetZProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double GlobalOffsetY
		{
			get
			{
				return (double)this.GetValue(GlobalOffsetYProperty);
			}
			set
			{
				this.SetValue(GlobalOffsetYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double GlobalOffsetX
		{
			get
			{
				return (double)this.GetValue(GlobalOffsetXProperty);
			}
			set
			{
				this.SetValue(GlobalOffsetXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double CenterOfRotationZ
		{
			get
			{
				return (double)this.GetValue(CenterOfRotationZProperty);
			}
			set
			{
				this.SetValue(CenterOfRotationZProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double CenterOfRotationY
		{
			get
			{
				return (double)this.GetValue(CenterOfRotationYProperty);
			}
			set
			{
				this.SetValue(CenterOfRotationYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double CenterOfRotationX
		{
			get
			{
				return (double)this.GetValue(CenterOfRotationXProperty);
			}
			set
			{
				this.SetValue(CenterOfRotationXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Media3D.Matrix3D ProjectionMatrix
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Media3D.Matrix3D)this.GetValue(ProjectionMatrixProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CenterOfRotationXProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"CenterOfRotationX", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CenterOfRotationYProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"CenterOfRotationY", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CenterOfRotationZProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"CenterOfRotationZ", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty GlobalOffsetXProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"GlobalOffsetX", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty GlobalOffsetYProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"GlobalOffsetY", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty GlobalOffsetZProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"GlobalOffsetZ", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LocalOffsetXProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"LocalOffsetX", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LocalOffsetYProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"LocalOffsetY", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LocalOffsetZProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"LocalOffsetZ", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ProjectionMatrixProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ProjectionMatrix", typeof(global::Microsoft.UI.Xaml.Media.Media3D.Matrix3D), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Media3D.Matrix3D)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty RotationXProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"RotationX", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty RotationYProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"RotationY", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty RotationZProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"RotationZ", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.PlaneProjection), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PlaneProjection() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.PlaneProjection", "PlaneProjection.PlaneProjection()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.PlaneProjection()
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetX.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetX.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetY.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetY.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetZ.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetZ.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationX.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationX.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationY.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationY.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationZ.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationZ.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationX.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationX.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationY.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationY.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationZ.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationZ.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetX.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetX.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetY.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetY.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetZ.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetZ.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.ProjectionMatrix.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetXProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetYProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.LocalOffsetZProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationXProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationYProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.RotationZProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationXProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationYProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.CenterOfRotationZProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetXProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetYProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.GlobalOffsetZProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.PlaneProjection.ProjectionMatrixProperty.get
	}
}