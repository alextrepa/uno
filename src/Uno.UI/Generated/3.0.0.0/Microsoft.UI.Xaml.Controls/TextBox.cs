#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextBox : global::Microsoft.UI.Xaml.Controls.IInputValidationControl
	{
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
		public  global::Microsoft.UI.Xaml.Controls.InputValidationContext ValidationContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputValidationContext TextBox.ValidationContext is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "InputValidationContext TextBox.ValidationContext");
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
		public  global::Windows.Foundation.Collections.IObservableVector<global::Microsoft.UI.Xaml.Controls.InputValidationError> ValidationErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<InputValidationError> TextBox.ValidationErrors is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool HasValidationErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TextBox.HasValidationErrors is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property TextWrapping
		// Skipping already declared property TextAlignment
		// Skipping already declared property Text
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public  int SelectionStart
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextBox.SelectionStart is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "int TextBox.SelectionStart");
			}
		}
		#endif
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public  int SelectionLength
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextBox.SelectionLength is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "int TextBox.SelectionLength");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string SelectedText
		{
			get
			{
				throw new global::System.NotImplementedException("The member string TextBox.SelectedText is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "string TextBox.SelectedText");
			}
		}
		#endif
		// Skipping already declared property MaxLength
		// Skipping already declared property IsTextPredictionEnabled
		// Skipping already declared property IsSpellCheckEnabled
		// Skipping already declared property IsReadOnly
		// Skipping already declared property InputScope
		// Skipping already declared property AcceptsReturn
		// Skipping already declared property HeaderTemplate
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsColorFontEnabled
		{
			get
			{
				return (bool)this.GetValue(IsColorFontEnabledProperty);
			}
			set
			{
				this.SetValue(IsColorFontEnabledProperty, value);
			}
		}
		#endif
		// Skipping already declared property PlaceholderText
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
		// Skipping already declared property Header
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.CandidateWindowAlignment DesiredCandidateWindowAlignment
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.CandidateWindowAlignment)this.GetValue(DesiredCandidateWindowAlignmentProperty);
			}
			set
			{
				this.SetValue(DesiredCandidateWindowAlignmentProperty, value);
			}
		}
		#endif
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
		public  global::Microsoft.UI.Xaml.Media.SolidColorBrush SelectionHighlightColorWhenNotFocused
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.SolidColorBrush)this.GetValue(SelectionHighlightColorWhenNotFocusedProperty);
			}
			set
			{
				this.SetValue(SelectionHighlightColorWhenNotFocusedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush PlaceholderForeground
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(PlaceholderForegroundProperty);
			}
			set
			{
				this.SetValue(PlaceholderForegroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.TextAlignment HorizontalTextAlignment
		{
			get
			{
				return (global::Microsoft.UI.Xaml.TextAlignment)this.GetValue(HorizontalTextAlignmentProperty);
			}
			set
			{
				this.SetValue(HorizontalTextAlignmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.CharacterCasing CharacterCasing
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.CharacterCasing)this.GetValue(CharacterCasingProperty);
			}
			set
			{
				this.SetValue(CharacterCasingProperty, value);
			}
		}
		#endif
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
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanRedo
		{
			get
			{
				return (bool)this.GetValue(CanRedoProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanUndo
		{
			get
			{
				return (bool)this.GetValue(CanUndoProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase ProofingMenuFlyout
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)this.GetValue(ProofingMenuFlyoutProperty);
			}
		}
		#endif
		// Skipping already declared property AcceptsReturnProperty
		// Skipping already declared property InputScopeProperty
		// Skipping already declared property IsReadOnlyProperty
		// Skipping already declared property IsSpellCheckEnabledProperty
		// Skipping already declared property IsTextPredictionEnabledProperty
		// Skipping already declared property MaxLengthProperty
		// Skipping already declared property TextAlignmentProperty
		// Skipping already declared property TextProperty
		// Skipping already declared property TextWrappingProperty
		// Skipping already declared property HeaderProperty
		// Skipping already declared property HeaderTemplateProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsColorFontEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsColorFontEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property PlaceholderTextProperty
		#if false || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PreventKeyboardDisplayOnProgrammaticFocus), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionHighlightColorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectionHighlightColor), typeof(global::Microsoft.UI.Xaml.Media.SolidColorBrush), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.SolidColorBrush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DesiredCandidateWindowAlignmentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(DesiredCandidateWindowAlignment), typeof(global::Microsoft.UI.Xaml.Controls.CandidateWindowAlignment), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.CandidateWindowAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TextReadingOrderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TextReadingOrder), typeof(global::Microsoft.UI.Xaml.TextReadingOrder), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.TextReadingOrder)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionHighlightColorWhenNotFocusedProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectionHighlightColorWhenNotFocused), typeof(global::Microsoft.UI.Xaml.Media.SolidColorBrush), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.SolidColorBrush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CharacterCasingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CharacterCasing), typeof(global::Microsoft.UI.Xaml.Controls.CharacterCasing), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.CharacterCasing)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalTextAlignmentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalTextAlignment), typeof(global::Microsoft.UI.Xaml.TextAlignment), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.TextAlignment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PlaceholderForegroundProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PlaceholderForeground), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanPasteClipboardContentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanPasteClipboardContent), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanRedoProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanRedo), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanUndoProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanUndo), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DescriptionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Description), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ProofingMenuFlyoutProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ProofingMenuFlyout), typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionFlyoutProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectionFlyout), typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ErrorTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ErrorTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputValidationKindProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputValidationKind), typeof(global::Microsoft.UI.Xaml.Controls.InputValidationKind), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputValidationKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputValidationModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputValidationMode), typeof(global::Microsoft.UI.Xaml.Controls.InputValidationMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.TextBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputValidationMode)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.TextBox.TextBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.Text.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.Text.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectedText.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectedText.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionStart.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionStart.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.MaxLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.MaxLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsReadOnly.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsReadOnly.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.AcceptsReturn.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.AcceptsReturn.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextAlignment.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextAlignment.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextWrapping.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextWrapping.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsSpellCheckEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsSpellCheckEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsTextPredictionEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsTextPredictionEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputScope.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputScope.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ContextMenuOpening.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ContextMenuOpening.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Select( int start,  int length)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "void TextBox.Select(int start, int length)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SelectAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "void TextBox.SelectAll()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Rect GetRectFromCharacterIndex( int charIndex,  bool trailingEdge)
		{
			throw new global::System.NotImplementedException("The member Rect TextBox.GetRectFromCharacterIndex(int charIndex, bool trailingEdge) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.Header.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.Header.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HeaderTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HeaderTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PlaceholderText.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PlaceholderText.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionHighlightColor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionHighlightColor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PreventKeyboardDisplayOnProgrammaticFocus.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PreventKeyboardDisplayOnProgrammaticFocus.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsColorFontEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsColorFontEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.Paste.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.Paste.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextCompositionStarted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextCompositionStarted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextCompositionChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextCompositionChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextCompositionEnded.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextCompositionEnded.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextReadingOrder.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextReadingOrder.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.DesiredCandidateWindowAlignment.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.DesiredCandidateWindowAlignment.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CandidateWindowBoundsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CandidateWindowBoundsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextChanging.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextChanging.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<string>> GetLinguisticAlternativesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<string>> TextBox.GetLinguisticAlternativesAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionHighlightColorWhenNotFocused.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionHighlightColorWhenNotFocused.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HorizontalTextAlignment.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HorizontalTextAlignment.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CharacterCasing.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CharacterCasing.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PlaceholderForeground.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PlaceholderForeground.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CopyingToClipboard.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CopyingToClipboard.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CuttingToClipboard.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CuttingToClipboard.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.BeforeTextChanging.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.BeforeTextChanging.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CanPasteClipboardContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CanUndo.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CanRedo.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionFlyout.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionFlyout.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ProofingMenuFlyout.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.Description.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.Description.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionChanging.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionChanging.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Undo()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "void TextBox.Undo()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Redo()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "void TextBox.Redo()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void PasteFromClipboard()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "void TextBox.PasteFromClipboard()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void CopySelectionToClipboard()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "void TextBox.CopySelectionToClipboard()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void CutSelectionToClipboard()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "void TextBox.CutSelectionToClipboard()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ClearUndoRedoHistory()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "void TextBox.ClearUndoRedoHistory()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HasValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ValidationContext.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ValidationContext.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ErrorTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ErrorTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputValidationMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputValidationMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputValidationKind.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputValidationKind.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HasValidationErrorsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HasValidationErrorsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ValidationError.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ValidationError.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ErrorTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputValidationModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputValidationKindProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CanPasteClipboardContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CanUndoProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CanRedoProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionFlyoutProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.ProofingMenuFlyoutProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.DescriptionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HorizontalTextAlignmentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.CharacterCasingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PlaceholderForegroundProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionHighlightColorWhenNotFocusedProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.DesiredCandidateWindowAlignmentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextReadingOrderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HeaderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.HeaderTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PlaceholderTextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.SelectionHighlightColorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.PreventKeyboardDisplayOnProgrammaticFocusProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsColorFontEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.MaxLengthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsReadOnlyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.AcceptsReturnProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextAlignmentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.TextWrappingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsSpellCheckEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.IsTextPredictionEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TextBox.InputScopeProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Controls.ContextMenuOpeningEventHandler ContextMenuOpening
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event ContextMenuOpeningEventHandler TextBox.ContextMenuOpening");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event ContextMenuOpeningEventHandler TextBox.ContextMenuOpening");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.Controls.TextBox.SelectionChanged
		// Skipping already declared event Microsoft.UI.Xaml.Controls.TextBox.TextChanged
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.Controls.TextControlPasteEventHandler Paste
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TextControlPasteEventHandler TextBox.Paste");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TextControlPasteEventHandler TextBox.Paste");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TextBox, global::Microsoft.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, CandidateWindowBoundsChangedEventArgs> TextBox.CandidateWindowBoundsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, CandidateWindowBoundsChangedEventArgs> TextBox.CandidateWindowBoundsChanged");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.Controls.TextBox.TextChanging
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TextBox, global::Microsoft.UI.Xaml.Controls.TextCompositionChangedEventArgs> TextCompositionChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextCompositionChangedEventArgs> TextBox.TextCompositionChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextCompositionChangedEventArgs> TextBox.TextCompositionChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TextBox, global::Microsoft.UI.Xaml.Controls.TextCompositionEndedEventArgs> TextCompositionEnded
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextCompositionEndedEventArgs> TextBox.TextCompositionEnded");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextCompositionEndedEventArgs> TextBox.TextCompositionEnded");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TextBox, global::Microsoft.UI.Xaml.Controls.TextCompositionStartedEventArgs> TextCompositionStarted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextCompositionStartedEventArgs> TextBox.TextCompositionStarted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextCompositionStartedEventArgs> TextBox.TextCompositionStarted");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.Controls.TextBox.BeforeTextChanging
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TextBox, global::Microsoft.UI.Xaml.Controls.TextControlCopyingToClipboardEventArgs> CopyingToClipboard
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextControlCopyingToClipboardEventArgs> TextBox.CopyingToClipboard");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextControlCopyingToClipboardEventArgs> TextBox.CopyingToClipboard");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TextBox, global::Microsoft.UI.Xaml.Controls.TextControlCuttingToClipboardEventArgs> CuttingToClipboard
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextControlCuttingToClipboardEventArgs> TextBox.CuttingToClipboard");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextControlCuttingToClipboardEventArgs> TextBox.CuttingToClipboard");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TextBox, global::Microsoft.UI.Xaml.Controls.TextBoxSelectionChangingEventArgs> SelectionChanging
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextBoxSelectionChangingEventArgs> TextBox.SelectionChanging");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<TextBox, TextBoxSelectionChangingEventArgs> TextBox.SelectionChanging");
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
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<IInputValidationControl, HasValidationErrorsChangedEventArgs> TextBox.HasValidationErrorsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<IInputValidationControl, HasValidationErrorsChangedEventArgs> TextBox.HasValidationErrorsChanged");
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
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<IInputValidationControl, InputValidationErrorEventArgs> TextBox.ValidationError");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TextBox", "event TypedEventHandler<IInputValidationControl, InputValidationErrorEventArgs> TextBox.ValidationError");
			}
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Controls.IInputValidationControl
	}
}
