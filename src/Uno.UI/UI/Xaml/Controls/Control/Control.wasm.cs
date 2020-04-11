﻿using Uno.UI.Controls;
using Uno.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.UI.Xaml.Media;
using Uno.Logging;
using System.Drawing;
using System.Linq;
using Microsoft.UI.Xaml.Input;
using Uno.Disposables;
using Uno.UI;
using View = Microsoft.UI.Xaml.UIElement;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class Control
	{
		/// This binary compatibility workaround that can be removed
		public new static DependencyProperty IsEnabledProperty => FrameworkElement.IsEnabledProperty;

		public Control(string htmlTag = "div") : base(htmlTag)
		{
			InitializeControl();
		}

		partial void UnregisterSubView()
		{
			var child = this.GetChildren()?.FirstOrDefault();
			if (child != null)
			{
				RemoveChild(child);
			}
		}

		partial void RegisterSubView(View child)
		{
			AddChild(child);
		}

		/// <summary>
		/// Gets the first sub-view of this control or null if there is none
		/// </summary>
		public IFrameworkElement GetTemplateRoot()
		{
			return this.GetChildren()?.FirstOrDefault() as IFrameworkElement;
		}

		partial void OnIsFocusableChanged()
		{
			var isFocusable = IsFocusable && !IsDelegatingFocusToTemplateChild();

			SetAttribute("tabindex", isFocusable ? "0" : "-1");
		}

		protected virtual bool IsDelegatingFocusToTemplateChild() => false;
	}
}
