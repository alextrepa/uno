﻿using System;
using Uno.UI.Samples.Controls;
using Microsoft.UI.Xaml.Controls;

namespace UITests.Shared.Windows_UI_Xaml_Controls.DatePicker
{
	[SampleControlInfo]
	public sealed partial class DatePickerFlyout_Automated : UserControl
	{
		public DatePickerFlyout_Automated()
		{
			InitializeComponent();

			TestDatePickerFlyout.Date = new DateTimeOffset(new DateTime(2019, 3, 12));
			TestDatePickerFlyout.DatePicked += (s, e) => selectedDate.Text = TestDatePickerFlyout.Date.ToString();
		}
	}
}
