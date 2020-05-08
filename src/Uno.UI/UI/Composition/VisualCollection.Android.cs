#if __ANDROID__
using System;

namespace Microsoft.UI.Composition
{
	public partial class VisualCollection : global::Microsoft.UI.Composition.CompositionObject, global::System.Collections.Generic.IEnumerable<global::Microsoft.UI.Composition.Visual>
	{
		private readonly Visual _owner;

		public VisualCollection(Visual owner)
		{
			_owner = owner;
		}

		partial void InsertAbovePartial(Visual newChild, Visual sibling)
		{
		}

		partial void InsertAtBottomPartial(Visual newChild)
		{
		}

		partial void InsertAtTopPartial(Visual newChild)
		{
		}

		partial void InsertBelowPartial(Visual newChild, Visual sibling)
		{
		}

		partial void RemoveAllPartial()
		{
		}

		partial void RemovePartial(Visual child)
		{
		}
	}
}
#endif
