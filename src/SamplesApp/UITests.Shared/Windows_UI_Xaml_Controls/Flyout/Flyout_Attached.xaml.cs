﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Shared.Windows_UI_Xaml_Controls.Flyout
{
	[SampleControlInfo("Flyout", "Flyout_Attached", description: "Demonstrates use of FlyoutBase.AttachedFlyout.")]
	public sealed partial class Flyout_Attached : UserControl
	{
		public Flyout_Attached()
		{
			this.InitializeComponent();
		}

		private void ShowFlyoutButton_Click(object sender, RoutedEventArgs e)
		{
			FlyoutBase.ShowAttachedFlyout(FlyoutTarget);
		}
	}
}
