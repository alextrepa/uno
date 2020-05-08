#if __ANDROID__
using System.Numerics;
using System;
using Android.Views;

namespace Microsoft.UI.Composition
{
	public partial class Visual : global::Microsoft.UI.Composition.CompositionObject
	{
		public View NativeOwner { get; set; }
	}
}
#endif