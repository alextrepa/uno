﻿using System;
using System.ComponentModel;
using Windows.UI;

namespace Microsoft.UI
{
    public static partial class ColorHelper
    {
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Color FromARGB(byte a, byte r, byte g, byte b) 
			=> Color.FromArgb(a, r, g, b);

		public static global::Windows.UI.Color FromArgb(byte a, byte r, byte g, byte b)
			=> Color.FromArgb(a, r, g, b);
	}
}
