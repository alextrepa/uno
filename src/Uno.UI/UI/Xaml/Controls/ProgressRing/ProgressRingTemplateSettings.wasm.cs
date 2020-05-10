﻿#if __WASM__

using Microsoft.UI.Xaml;

namespace Uno.UI.Controls.Legacy
{//TODO: Fully implement this class, matching UWP https://github.com/unoplatform/uno/issues/1872
	public partial class ProgressRingTemplateSettings : DependencyObject
	{
		public double EllipseDiameter { get; set; }

		public Thickness EllipseOffset { get; set; }

		public double MaxSideLength { get; set; }
	}
}

#endif
