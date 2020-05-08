#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UIElementWeakCollection : global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.UIElement>,global::System.Collections.Generic.IEnumerable<global::Microsoft.UI.Xaml.UIElement>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint UIElementWeakCollection.Size is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public UIElementWeakCollection() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.UIElementWeakCollection", "UIElementWeakCollection.UIElementWeakCollection()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.UIElementWeakCollection()
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.GetAt(uint)
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.Size.get
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.GetView()
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.IndexOf(Microsoft.UI.Xaml.UIElement, out uint)
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.SetAt(uint, Microsoft.UI.Xaml.UIElement)
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.InsertAt(uint, Microsoft.UI.Xaml.UIElement)
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.RemoveAt(uint)
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.Append(Microsoft.UI.Xaml.UIElement)
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.RemoveAtEnd()
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.Clear()
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.GetMany(uint, Microsoft.UI.Xaml.UIElement[])
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.ReplaceAll(Microsoft.UI.Xaml.UIElement[])
		// Forced skipping of method Microsoft.UI.Xaml.UIElementWeakCollection.First()
		// Processing: System.Collections.Generic.IList<Microsoft.UI.Xaml.UIElement>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public int IndexOf( global::Microsoft.UI.Xaml.UIElement item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public void Insert( int index,  global::Microsoft.UI.Xaml.UIElement item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public void RemoveAt( int index)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public global::Microsoft.UI.Xaml.UIElement this[int index]
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}
		#endif
		// Processing: System.Collections.Generic.ICollection<Microsoft.UI.Xaml.UIElement>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public void Add( global::Microsoft.UI.Xaml.UIElement item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public bool Contains( global::Microsoft.UI.Xaml.UIElement item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public void CopyTo( global::Microsoft.UI.Xaml.UIElement[] array,  int arrayIndex)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public bool Remove( global::Microsoft.UI.Xaml.UIElement item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public int Count
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public bool IsReadOnly
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}
		#endif
		// Processing: System.Collections.Generic.IEnumerable<Microsoft.UI.Xaml.UIElement>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<Microsoft.UI.Xaml.UIElement>
		[global::Uno.NotImplemented]
		public global::System.Collections.Generic.IEnumerator<global::Microsoft.UI.Xaml.UIElement> GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		// Processing: System.Collections.IEnumerable
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		// DeclaringType: System.Collections.IEnumerable
		[global::Uno.NotImplemented]
		 global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
	}
}
