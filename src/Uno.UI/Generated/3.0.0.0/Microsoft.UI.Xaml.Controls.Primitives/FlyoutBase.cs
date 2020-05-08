#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class FlyoutBase : global::Microsoft.UI.Xaml.DependencyObject
	{
		// Skipping already declared property Placement
		// Skipping already declared property LightDismissOverlayMode
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.ElementSoundMode ElementSoundMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.ElementSoundMode)this.GetValue(ElementSoundModeProperty);
			}
			set
			{
				this.SetValue(ElementSoundModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AllowFocusWhenDisabled
		{
			get
			{
				return (bool)this.GetValue(AllowFocusWhenDisabledProperty);
			}
			set
			{
				this.SetValue(AllowFocusWhenDisabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AllowFocusOnInteraction
		{
			get
			{
				return (bool)this.GetValue(AllowFocusOnInteractionProperty);
			}
			set
			{
				this.SetValue(AllowFocusOnInteractionProperty, value);
			}
		}
		#endif
		// Skipping already declared property Target
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject OverlayInputPassThroughElement
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(OverlayInputPassThroughElementProperty);
			}
			set
			{
				this.SetValue(OverlayInputPassThroughElementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutShowMode ShowMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutShowMode)this.GetValue(ShowModeProperty);
			}
			set
			{
				this.SetValue(ShowModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreOpenCloseAnimationsEnabled
		{
			get
			{
				return (bool)this.GetValue(AreOpenCloseAnimationsEnabledProperty);
			}
			set
			{
				this.SetValue(AreOpenCloseAnimationsEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool InputDevicePrefersPrimaryCommands
		{
			get
			{
				return (bool)this.GetValue(InputDevicePrefersPrimaryCommandsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsOpen
		{
			get
			{
				return (bool)this.GetValue(IsOpenProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.XamlRoot XamlRoot
		{
			get
			{
				throw new global::System.NotImplementedException("The member XamlRoot FlyoutBase.XamlRoot is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase", "XamlRoot FlyoutBase.XamlRoot");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ShouldConstrainToRootBounds
		{
			get
			{
				return (bool)this.GetValue(ShouldConstrainToRootBoundsProperty);
			}
			set
			{
				this.SetValue(ShouldConstrainToRootBoundsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsConstrainedToRootBounds
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool FlyoutBase.IsConstrainedToRootBounds is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AttachedFlyoutProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"AttachedFlyout", typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)));
		#endif
		// Skipping already declared property PlacementProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AllowFocusOnInteractionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AllowFocusOnInteraction), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AllowFocusWhenDisabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AllowFocusWhenDisabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ElementSoundModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ElementSoundMode), typeof(global::Microsoft.UI.Xaml.ElementSoundMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.ElementSoundMode)));
		#endif
		// Skipping already declared property LightDismissOverlayModeProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OverlayInputPassThroughElementProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(OverlayInputPassThroughElement), typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AreOpenCloseAnimationsEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AreOpenCloseAnimationsEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputDevicePrefersPrimaryCommandsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputDevicePrefersPrimaryCommands), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsOpenProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsOpen), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ShowModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ShowMode), typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutShowMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutShowMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Target), typeof(global::Microsoft.UI.Xaml.FrameworkElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.FrameworkElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ShouldConstrainToRootBoundsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ShouldConstrainToRootBounds), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.FlyoutBase()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.FlyoutBase()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Placement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Placement.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Opened.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Opened.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Closed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Closed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Opening.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Opening.remove
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShowAt(Microsoft.UI.Xaml.FrameworkElement)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Hide()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Target.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AllowFocusOnInteraction.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AllowFocusOnInteraction.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.LightDismissOverlayMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.LightDismissOverlayMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AllowFocusWhenDisabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AllowFocusWhenDisabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ElementSoundMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ElementSoundMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Closing.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Closing.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElement.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void TryInvokeKeyboardAccelerator( global::Microsoft.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase", "void FlyoutBase.TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShowMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShowMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.InputDevicePrefersPrimaryCommands.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AreOpenCloseAnimationsEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AreOpenCloseAnimationsEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.IsOpen.get
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShowAt(Microsoft.UI.Xaml.DependencyObject, Microsoft.UI.Xaml.Controls.Primitives.FlyoutShowOptions)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShouldConstrainToRootBounds.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShouldConstrainToRootBounds.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.IsConstrainedToRootBounds.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.XamlRoot.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.XamlRoot.set
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.CreatePresenter()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnProcessKeyboardAccelerators( global::Microsoft.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase", "void FlyoutBase.OnProcessKeyboardAccelerators(ProcessKeyboardAcceleratorEventArgs args)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShouldConstrainToRootBoundsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.TargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShowModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.InputDevicePrefersPrimaryCommandsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AreOpenCloseAnimationsEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.IsOpenProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AllowFocusOnInteractionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.LightDismissOverlayModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AllowFocusWhenDisabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ElementSoundModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.PlacementProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty.get
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.GetAttachedFlyout(Microsoft.UI.Xaml.FrameworkElement)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.SetAttachedFlyout(Microsoft.UI.Xaml.FrameworkElement, Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.ShowAttachedFlyout(Microsoft.UI.Xaml.FrameworkElement)
		// Skipping already declared event Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Closed
		// Skipping already declared event Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Opened
		// Skipping already declared event Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Opening
		// Skipping already declared event Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.Closing
	}
}
