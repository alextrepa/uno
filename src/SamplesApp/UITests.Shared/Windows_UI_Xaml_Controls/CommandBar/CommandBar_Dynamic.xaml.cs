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

namespace Uno.UI.Samples.Content.UITests.CommandBar
{
	[SampleControlInfo("CommandBar", "Dynamic", ignoreInSnapshotTests: true)]
	public sealed partial class CommandBar_Dynamic : UserControl
	{
		public CommandBar_Dynamic()
		{
			this.InitializeComponent();

			cbVisibility.ItemsSource = Visibilities;
			cbVisibility.SelectedItem = Microsoft.UI.Xaml.Visibility.Visible;

			CommandVisibility.ItemsSource = Visibilities;
			CommandVisibility.SelectedItem = Microsoft.UI.Xaml.Visibility.Visible;

			BackgroundColor.ItemsSource = Colors;
			BackgroundColor.SelectedItem = Windows.UI.Colors.Red;

			ForegroundColor.ItemsSource = Colors;
			ForegroundColor.SelectedItem = Windows.UI.Colors.Black;

			CommandIsEnabled.ItemsSource = Booleans;
			CommandIsEnabled.SelectedItem = true;
		}

		public Windows.UI.Color[] Colors = new[]
		{
			Windows.UI.Colors.Black,
			Windows.UI.Colors.White,
			Windows.UI.Colors.Red,
			Windows.UI.Colors.Green,
			Windows.UI.Colors.Blue,
		};

		public bool[] Booleans = new[]
		{
			true,
			false,
		};

		public Microsoft.UI.Xaml.Visibility[] Visibilities = new[]
		{
			Microsoft.UI.Xaml.Visibility.Visible,
			Microsoft.UI.Xaml.Visibility.Collapsed,
		};
	}
}
