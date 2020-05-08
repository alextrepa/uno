using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Uno.UI.Common;
using Uno.UI.Samples.UITests.Helpers;
using Windows.UI.Core;

#if HAS_UNO
using ICommand = System.Windows.Input.ICommand;
#else
using ICommand = Microsoft.UI.Xaml.Input.ICommand;
#endif

namespace Uno.UI.Samples.Presentation.SamplePages
{
	public class TouchViewModel : ViewModelBase
	{
		private int commandCount = 0;

		public TouchViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
			GenericCommand = new DelegateCommand<string>(p => Output = $"{commandCount++} - {p}");
		}

		public string[] Colors { get; } = new[] { "Red", "Blue", "Yellow", "Orange", "Green", "Purple" };

		private string _output = "No touch event raised";

		public string Output
		{
			get { return _output; }
			set
			{
				_output = value;
				RaisePropertyChanged();
			}
		}


		public ICommand GenericCommand { get; }
	}
}
