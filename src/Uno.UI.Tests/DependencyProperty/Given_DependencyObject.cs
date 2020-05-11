﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.UI.DataBinding;

namespace Uno.UI.Tests
{
	[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
	public partial class Given_DependencyObject
	{
		[TestMethod]
		public void When_AreDifferent()
		{
			var o1 = new object();
			var o2 = new object();

			// We build our strings from a char array to prevent strings
			// obtained as literals from being reused due to intering
			// in order to ensure that references are different 
			// and provide accurate ReferenceEqual results.
			char[] chars = { 'h', 'e', 'l', 'l', 'o' };
			var s1 = new string(chars);
			var s2 = new string(chars);

			Assert.IsFalse(DependencyObjectStore.AreDifferent(null, null));
			Assert.IsFalse(DependencyObjectStore.AreDifferent(0, 0));
			Assert.IsFalse(DependencyObjectStore.AreDifferent(0.0, 0.0));
			Assert.IsFalse(DependencyObjectStore.AreDifferent(o1, o1));
			Assert.IsFalse(DependencyObjectStore.AreDifferent(o2, o2));
			Assert.IsFalse(DependencyObjectStore.AreDifferent(s1, s2));
			Assert.IsFalse(DependencyObjectStore.AreDifferent(1.ToString(), 1.ToString()));
			Assert.IsFalse(DependencyObjectStore.AreDifferent("", ""));
			Assert.IsFalse(DependencyObjectStore.AreDifferent("1", "1"));

			Assert.IsTrue(DependencyObjectStore.AreDifferent(0, null));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(null, 0));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(1, 0));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(0, 0.0));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(Visibility.Collapsed, null));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(null, Visibility.Collapsed));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(Visibility.Collapsed, Visibility.Visible));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(Visibility.Visible, Visibility.Collapsed));

			Assert.IsTrue(DependencyObjectStore.AreDifferent(o1, null));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(null, o1));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(o1, o2));

			Assert.IsTrue(DependencyObjectStore.AreDifferent("", null));
			Assert.IsTrue(DependencyObjectStore.AreDifferent("", "1"));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(null, "1"));
			Assert.IsTrue(DependencyObjectStore.AreDifferent("1", "2"));

			var mo1a = new MyObject(1);
			var mo1b = new MyObject(1);
			var mo2 = new MyObject(2);
			Assert.IsFalse(DependencyObjectStore.AreDifferent(mo1a, mo1a));

			Assert.IsTrue(DependencyObjectStore.AreDifferent(mo1a, mo1b));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(mo1b, mo1a));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(mo1a, mo2));
			Assert.IsTrue(DependencyObjectStore.AreDifferent(mo1b, mo2));
		}

		[TestMethod]
		public void When_Set_Parent()
		{
			var child = new MyObject(12);
			var parent = new MyObject(144);

			var store = new DependencyObjectStore(child, MyObject.DataContextProperty, MyObject.TemplatedParentProperty);
			store.Parent = parent;
			Assert.AreEqual(parent, store.Parent);

			store.Parent = null;
			Assert.AreEqual(null, store.Parent);
		}

		[TestMethod]
		public void When_Set_Parent_As_WeakReferenceProvider()
		{
			var child = new MyObject(12);
			var parent = new MyProvider();

			var store = new DependencyObjectStore(child, MyObject.DataContextProperty, MyObject.TemplatedParentProperty);
			store.Parent = parent;
			Assert.AreEqual(parent, store.Parent);

			store.Parent = null;
			Assert.AreEqual(null, store.Parent);
		}

		public partial class MyObject : DependencyObject
		{
			public MyObject(int value)
			{
				Value = value;
			}

			public int Value { get; private set; }

			public override bool Equals(object obj)
			{
				var myObj = obj as MyObject;

				if (myObj != null)
				{
					return myObj.Value == Value;
				}

				return false;
			}

			public override int GetHashCode() => Value.GetHashCode();
		}

	}

	public partial class MyProvider : DependencyObject
	{
			
	}
}
