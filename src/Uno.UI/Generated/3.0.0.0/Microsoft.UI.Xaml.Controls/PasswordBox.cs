#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PasswordBox : global::Microsoft.UI.Xaml.Controls.IInputValidationControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationContext ValidationContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputValidationContext PasswordBox.ValidationContext is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "InputValidationContext PasswordBox.ValidationContext");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationMode InputValidationMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.InputValidationMode)this.GetValue(InputValidationModeProperty);
			}
			set
			{
				this.SetValue(InputValidationModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationKind InputValidationKind
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.InputValidationKind)this.GetValue(InputValidationKindProperty);
			}
			set
			{
				this.SetValue(InputValidationKindProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DataTemplate ErrorTemplate
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DataTemplate)this.GetValue(ErrorTemplateProperty);
			}
			set
			{
				this.SetValue(ErrorTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool HasValidationErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PasswordBox.HasValidationErrors is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Collections.IObservableVector<global::Microsoft.UI.Xaml.Controls.InputValidationError> ValidationErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<InputValidationError> PasswordBox.ValidationErrors is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string PasswordChar
		{
			get
			{
				return (string)this.GetValue(PasswordCharProperty);
			}
			set
			{
				this.SetValue(PasswordCharProperty, value);
			}
		}
		#endif
		// Skipping already declared property Password
		// Skipping already declared property MaxLength
		// Skipping already declared property IsPasswordRevealButtonEnabled
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.SolidColorBrush SelectionHighlightColor
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.SolidColorBrush)this.GetValue(SelectionHighlightColorProperty);
			}
			set
			{
				this.SetValue(SelectionHighlightColorProperty, value);
			}
		}
		#endif
		#if false || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool PreventKeyboardDisplayOnProgrammaticFocus
		{
			get
			{
				return (bool)this.GetValue(PreventKeyboardDisplayOnProgrammaticFocusProperty);
			}
			set
			{
				this.SetValue(PreventKeyboardDisplayOnProgrammaticFocusProperty, value);
			}
		}
		#endif
		// Skipping already declared property PlaceholderText
		// Skipping already declared property HeaderTemplate
		// Skipping already declared property Header
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.TextReadingOrder TextReadingOrder
		{
			get
			{
				return (global::Microsoft.UI.Xaml.TextReadingOrder)this.GetValue(TextReadingOrderProperty);
			}
			set
			{
				this.SetValue(TextReadingOrderProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.PasswordRevealMode PasswordRevealMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.PasswordRevealMode)this.GetValue(PasswordRevealModeProperty);
			}
			set
			{
				this.SetValue(PasswordRevealModeProperty, value);
			}
		}
		#endif
		// Skipping already declared property InputScope
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase SelectionFlyout
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)this.GetValue(SelectionFlyoutProperty);
			}
			set
			{
				this.SetValue(SelectionFlyoutProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object Description
		{
			get
			{
				return (object)this.GetValue(DescriptionProperty);
			}
			set
			{
				this.SetValue(DescriptionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanPasteClipboardContent
		{
			get
			{
				return (bool)this.GetValue(CanPasteClipboardContentProperty);
			}
		}
		#endif
		// Skipping already declared property IsPasswordRevealButtonEnabledProperty
		// Skipping already declared property MaxLengthProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PasswordCharProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PasswordChar), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		// Skipping already declared property PasswordProperty
		// Skipping already declared property HeaderProperty
		// Skipping already declared property HeaderTemplateProperty
		// Skipping already declared property PlaceholderTextProperty
		#if false || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PreventKeyboardDisplayOnProgrammaticFocus), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionHighlightColorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectionHighlightColor), typeof(global::Microsoft.UI.Xaml.Media.SolidColorBrush), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.SolidColorBrush)));
		#endif
		// Skipping already declared property InputScopeProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PasswordRevealModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PasswordRevealMode), typeof(global::Microsoft.UI.Xaml.Controls.PasswordRevealMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.PasswordRevealMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TextReadingOrderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TextReadingOrder), typeof(global::Microsoft.UI.Xaml.TextReadingOrder), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.TextReadingOrder)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanPasteClipboardContentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanPasteClipboardContent), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DescriptionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Description), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionFlyoutProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectionFlyout), typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ErrorTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ErrorTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputValidationKindProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputValidationKind), typeof(global::Microsoft.UI.Xaml.Controls.InputValidationKind), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputValidationKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputValidationModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputValidationMode), typeof(global::Microsoft.UI.Xaml.Controls.InputValidationMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputValidationMode)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Password.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Password.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChar.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChar.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.IsPasswordRevealButtonEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.IsPasswordRevealButtonEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.MaxLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.MaxLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ContextMenuOpening.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ContextMenuOpening.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SelectAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "void PasswordBox.SelectAll()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Header.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Header.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HeaderTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HeaderTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PlaceholderText.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PlaceholderText.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionHighlightColor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionHighlightColor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PreventKeyboardDisplayOnProgrammaticFocus.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PreventKeyboardDisplayOnProgrammaticFocus.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Paste.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Paste.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordRevealMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordRevealMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.TextReadingOrder.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.TextReadingOrder.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputScope.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputScope.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanging.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanging.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.CanPasteClipboardContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionFlyout.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionFlyout.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Description.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Description.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PasteFromClipboard()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "void PasswordBox.PasteFromClipboard()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HasValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ValidationContext.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ValidationContext.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ErrorTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ErrorTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputValidationMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputValidationMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputValidationKind.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputValidationKind.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HasValidationErrorsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HasValidationErrorsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ValidationError.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ValidationError.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ErrorTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputValidationModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputValidationKindProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.CanPasteClipboardContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionFlyoutProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.DescriptionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordRevealModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.TextReadingOrderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputScopeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HeaderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HeaderTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PlaceholderTextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionHighlightColorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PreventKeyboardDisplayOnProgrammaticFocusProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordCharProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.IsPasswordRevealButtonEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.MaxLengthProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Controls.ContextMenuOpeningEventHandler ContextMenuOpening
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event ContextMenuOpeningEventHandler PasswordBox.ContextMenuOpening");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event ContextMenuOpeningEventHandler PasswordBox.ContextMenuOpening");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanged
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Controls.TextControlPasteEventHandler Paste
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TextControlPasteEventHandler PasswordBox.Paste");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TextControlPasteEventHandler PasswordBox.Paste");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.PasswordBox, global::Microsoft.UI.Xaml.Controls.PasswordBoxPasswordChangingEventArgs> PasswordChanging
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TypedEventHandler<PasswordBox, PasswordBoxPasswordChangingEventArgs> PasswordBox.PasswordChanging");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TypedEventHandler<PasswordBox, PasswordBoxPasswordChangingEventArgs> PasswordBox.PasswordChanging");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.IInputValidationControl, global::Microsoft.UI.Xaml.Controls.HasValidationErrorsChangedEventArgs> HasValidationErrorsChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TypedEventHandler<IInputValidationControl, HasValidationErrorsChangedEventArgs> PasswordBox.HasValidationErrorsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TypedEventHandler<IInputValidationControl, HasValidationErrorsChangedEventArgs> PasswordBox.HasValidationErrorsChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.IInputValidationControl, global::Microsoft.UI.Xaml.Controls.InputValidationErrorEventArgs> ValidationError
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TypedEventHandler<IInputValidationControl, InputValidationErrorEventArgs> PasswordBox.ValidationError");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TypedEventHandler<IInputValidationControl, InputValidationErrorEventArgs> PasswordBox.ValidationError");
			}
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Controls.IInputValidationControl
	}
}
