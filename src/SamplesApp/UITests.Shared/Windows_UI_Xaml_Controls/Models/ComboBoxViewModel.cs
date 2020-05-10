﻿using System.Windows.Input;
using Windows.UI.Core;
using Microsoft.UI.Xaml.Data;
using Uno.UI.Samples.UITests.Helpers;

#if HAS_UNO
using ICommand = System.Windows.Input.ICommand;
using EventHandler = System.EventHandler;
#else
using ICommand = Microsoft.UI.Xaml.Input.ICommand;
using EventHandler = System.EventHandler<object>;
using EventArgs = System.Object;
#endif

namespace SamplesApp.Windows_UI_Xaml_Controls.Models
{
	[Bindable]
	public class ComboBoxViewModel : ViewModelBase
	{
		private string _header;
		private const string HeaderText = "Please select:";

		public ComboBoxViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
		}

		public string Header
		{
			get => _header;
			set
			{
				_header = value;
				RaisePropertyChanged();
			}
		}

		public ICommand ToggleHeader => GetOrCreateCommand(() => Header = Header == null ? HeaderText : null);
	}
}
