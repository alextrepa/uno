﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windows.UI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace Uno.UI.Tests.DatePickerTests
{
	[TestClass]
	public class Given_DatePicker
	{
		[TestMethod]
		public void Verify_LightDismissOverlayBackground()
		{
			var app = UnitTestsApp.App.EnsureApplication();
			Assert.IsNotNull(app.Resources["DatePickerLightDismissOverlayBackground"]);
			var dp = new DatePicker();
			Assert.AreEqual(Microsoft.UI.Colors.Orchid, (dp.LightDismissOverlayBackground as SolidColorBrush)?.Color);
		}
	}
}
