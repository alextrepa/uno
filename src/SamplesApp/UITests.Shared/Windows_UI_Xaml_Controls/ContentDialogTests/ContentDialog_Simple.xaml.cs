﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Common;
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

#if HAS_UNO
using ICommand = System.Windows.Input.ICommand;
#else
using ICommand = Microsoft.UI.Xaml.Input.ICommand;
#endif

namespace UITests.Shared.Windows_UI_Xaml_Controls.ContentDialogTests
{
	[SampleControlInfo("ContentDialog", "ContentDialog_Simple")]
	public sealed partial class ContentDialog_Simple : UserControl
	{
		public ContentDialog_Simple()
		{
			this.InitializeComponent();
		}

		private async void OnMyButtonClick(object sender, object args)
		{
			var result = await new ContentDialog_Simple_Dialog().ShowAsync();
			dialogResult.Text = result.ToString();
		}

		private async void OnMyButtonClick2(object sender, object args)
		{
			var result = await new ContentDialog_Simple_Dialog() { CloseButtonText = "Close" }.ShowAsync();
			dialogResult.Text = result.ToString();
		}

		private async void OnMyButtonClick3(object sender, object args)
		{
			var result = await new ContentDialog_Simple_Dialog() { IsPrimaryButtonEnabled = false }.ShowAsync();
			dialogResult.Text = result.ToString();
		}

		private async void OnMyButtonClick4(object sender, object args)
		{
			var result = await new ContentDialog_Simple_Dialog() { PrimaryButtonCommand = new DelegateCommand(() => commandResult.Text = "primaryCommand") }.ShowAsync();
			dialogResult.Text = result.ToString();
		}

		private async void OnMyButtonClick5(object sender, object args)
		{
			var result = await new ContentDialog_Simple_Dialog() { DefaultButton = ContentDialogButton.Primary }.ShowAsync();
			dialogResult.Text = result.ToString();
		}

		ContentDialog_Simple_Dialog _dialog6;

		private async void OnMyButtonClick6(object sender, object args)
		{
			if (_dialog6 == null)
			{
				_dialog6 = new ContentDialog_Simple_Dialog { };
			}

			var result = await _dialog6.ShowAsync();
			dialogResult.Text = result.ToString();
		}

		private void ContentDialog_PrimaryButtonClick(object sender, ContentDialogButtonClickEventArgs args)
		{

		}

		private void ContentDialog_SecondaryButtonClick(object sender, ContentDialogButtonClickEventArgs args)
		{

		}
	}
}
