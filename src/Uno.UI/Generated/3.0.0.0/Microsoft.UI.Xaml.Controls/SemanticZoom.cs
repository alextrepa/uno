#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SemanticZoom : global::Microsoft.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ISemanticZoomInformation ZoomedOutView
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ISemanticZoomInformation)this.GetValue(ZoomedOutViewProperty);
			}
			set
			{
				this.SetValue(ZoomedOutViewProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ISemanticZoomInformation ZoomedInView
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ISemanticZoomInformation)this.GetValue(ZoomedInViewProperty);
			}
			set
			{
				this.SetValue(ZoomedInViewProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsZoomedInViewActive
		{
			get
			{
				return (bool)this.GetValue(IsZoomedInViewActiveProperty);
			}
			set
			{
				this.SetValue(IsZoomedInViewActiveProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsZoomOutButtonEnabled
		{
			get
			{
				return (bool)this.GetValue(IsZoomOutButtonEnabledProperty);
			}
			set
			{
				this.SetValue(IsZoomOutButtonEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanChangeViews
		{
			get
			{
				return (bool)this.GetValue(CanChangeViewsProperty);
			}
			set
			{
				this.SetValue(CanChangeViewsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanChangeViewsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanChangeViews), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.SemanticZoom), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsZoomOutButtonEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsZoomOutButtonEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.SemanticZoom), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsZoomedInViewActiveProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsZoomedInViewActive), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.SemanticZoom), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomedInViewProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ZoomedInView), typeof(global::Microsoft.UI.Xaml.Controls.ISemanticZoomInformation), 
			typeof(global::Microsoft.UI.Xaml.Controls.SemanticZoom), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ISemanticZoomInformation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomedOutViewProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ZoomedOutView), typeof(global::Microsoft.UI.Xaml.Controls.ISemanticZoomInformation), 
			typeof(global::Microsoft.UI.Xaml.Controls.SemanticZoom), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ISemanticZoomInformation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SemanticZoom() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SemanticZoom", "SemanticZoom.SemanticZoom()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.SemanticZoom()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ZoomedInView.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ZoomedInView.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ZoomedOutView.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ZoomedOutView.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.IsZoomedInViewActive.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.IsZoomedInViewActive.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.CanChangeViews.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.CanChangeViews.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ViewChangeStarted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ViewChangeStarted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ViewChangeCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ViewChangeCompleted.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ToggleActiveView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SemanticZoom", "void SemanticZoom.ToggleActiveView()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.IsZoomOutButtonEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.IsZoomOutButtonEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ZoomedInViewProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.ZoomedOutViewProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.IsZoomedInViewActiveProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.CanChangeViewsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SemanticZoom.IsZoomOutButtonEnabledProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Controls.SemanticZoomViewChangedEventHandler ViewChangeCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SemanticZoom", "event SemanticZoomViewChangedEventHandler SemanticZoom.ViewChangeCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SemanticZoom", "event SemanticZoomViewChangedEventHandler SemanticZoom.ViewChangeCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Controls.SemanticZoomViewChangedEventHandler ViewChangeStarted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SemanticZoom", "event SemanticZoomViewChangedEventHandler SemanticZoom.ViewChangeStarted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SemanticZoom", "event SemanticZoomViewChangedEventHandler SemanticZoom.ViewChangeStarted");
			}
		}
		#endif
	}
}
