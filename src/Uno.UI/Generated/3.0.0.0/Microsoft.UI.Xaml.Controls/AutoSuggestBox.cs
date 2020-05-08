#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class AutoSuggestBox : global::Microsoft.UI.Xaml.Controls.ItemsControl,global::Microsoft.UI.Xaml.Controls.IInputValidationControl
	{
		// Skipping already declared property UpdateTextOnSelect
		// Skipping already declared property TextMemberPath
		// Skipping already declared property TextBoxStyle
		// Skipping already declared property Text
		// Skipping already declared property PlaceholderText
		// Skipping already declared property MaxSuggestionListHeight
		// Skipping already declared property IsSuggestionListOpen
		// Skipping already declared property Header
		// Skipping already declared property AutoMaximizeSuggestionArea
		// Skipping already declared property QueryIcon
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode LightDismissOverlayMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode)this.GetValue(LightDismissOverlayModeProperty);
			}
			set
			{
				this.SetValue(LightDismissOverlayModeProperty, value);
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
		public  global::Microsoft.UI.Xaml.Controls.InputValidationContext ValidationContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputValidationContext AutoSuggestBox.ValidationContext is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.AutoSuggestBox", "InputValidationContext AutoSuggestBox.ValidationContext");
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
				throw new global::System.NotImplementedException("The member bool AutoSuggestBox.HasValidationErrors is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Collections.IObservableVector<global::Microsoft.UI.Xaml.Controls.InputValidationError> ValidationErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<InputValidationError> AutoSuggestBox.ValidationErrors is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property AutoMaximizeSuggestionAreaProperty
		// Skipping already declared property HeaderProperty
		// Skipping already declared property IsSuggestionListOpenProperty
		// Skipping already declared property MaxSuggestionListHeightProperty
		// Skipping already declared property PlaceholderTextProperty
		// Skipping already declared property TextBoxStyleProperty
		// Skipping already declared property TextMemberPathProperty
		// Skipping already declared property TextProperty
		// Skipping already declared property UpdateTextOnSelectProperty
		// Skipping already declared property QueryIconProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LightDismissOverlayModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(LightDismissOverlayMode), typeof(global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.AutoSuggestBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DescriptionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Description), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.AutoSuggestBox), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ErrorTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ErrorTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.AutoSuggestBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputValidationKindProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputValidationKind), typeof(global::Microsoft.UI.Xaml.Controls.InputValidationKind), 
			typeof(global::Microsoft.UI.Xaml.Controls.AutoSuggestBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputValidationKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputValidationModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputValidationMode), typeof(global::Microsoft.UI.Xaml.Controls.InputValidationMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.AutoSuggestBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputValidationMode)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.AutoSuggestBox.AutoSuggestBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.AutoSuggestBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.MaxSuggestionListHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.MaxSuggestionListHeight.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.IsSuggestionListOpen.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.IsSuggestionListOpen.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextMemberPath.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextMemberPath.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.Text.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.Text.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.UpdateTextOnSelect.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.UpdateTextOnSelect.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.PlaceholderText.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.PlaceholderText.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.Header.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.Header.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.AutoMaximizeSuggestionArea.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.AutoMaximizeSuggestionArea.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextBoxStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextBoxStyle.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.SuggestionChosen.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.SuggestionChosen.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.QueryIcon.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.QueryIcon.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.QuerySubmitted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.QuerySubmitted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.LightDismissOverlayMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.LightDismissOverlayMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.Description.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.Description.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.ValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.HasValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.ValidationContext.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.ValidationContext.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.ErrorTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.ErrorTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.InputValidationMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.InputValidationMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.InputValidationKind.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.InputValidationKind.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.HasValidationErrorsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.HasValidationErrorsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.ValidationError.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.ValidationError.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.ErrorTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.InputValidationModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.InputValidationKindProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.DescriptionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.LightDismissOverlayModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.QueryIconProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.MaxSuggestionListHeightProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.IsSuggestionListOpenProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextMemberPathProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.UpdateTextOnSelectProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.PlaceholderTextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.HeaderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.AutoMaximizeSuggestionAreaProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextBoxStyleProperty.get
		// Skipping already declared event Microsoft.UI.Xaml.Controls.AutoSuggestBox.SuggestionChosen
		// Skipping already declared event Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextChanged
		// Skipping already declared event Microsoft.UI.Xaml.Controls.AutoSuggestBox.QuerySubmitted
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.IInputValidationControl, global::Microsoft.UI.Xaml.Controls.HasValidationErrorsChangedEventArgs> HasValidationErrorsChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.AutoSuggestBox", "event TypedEventHandler<IInputValidationControl, HasValidationErrorsChangedEventArgs> AutoSuggestBox.HasValidationErrorsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.AutoSuggestBox", "event TypedEventHandler<IInputValidationControl, HasValidationErrorsChangedEventArgs> AutoSuggestBox.HasValidationErrorsChanged");
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
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.AutoSuggestBox", "event TypedEventHandler<IInputValidationControl, InputValidationErrorEventArgs> AutoSuggestBox.ValidationError");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.AutoSuggestBox", "event TypedEventHandler<IInputValidationControl, InputValidationErrorEventArgs> AutoSuggestBox.ValidationError");
			}
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Controls.IInputValidationControl
	}
}
