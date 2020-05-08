#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemsRepeater : global::Microsoft.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalCacheLength
		{
			get
			{
				return (double)this.GetValue(VerticalCacheLengthProperty);
			}
			set
			{
				this.SetValue(VerticalCacheLengthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Layout Layout
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Layout)this.GetValue(LayoutProperty);
			}
			set
			{
				this.SetValue(LayoutProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ItemsSource
		{
			get
			{
				return (object)this.GetValue(ItemsSourceProperty);
			}
			set
			{
				this.SetValue(ItemsSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  object ItemTemplate
		{
			get
			{
				return (object)this.GetValue(ItemTemplateProperty);
			}
			set
			{
				this.SetValue(ItemTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalCacheLength
		{
			get
			{
				return (double)this.GetValue(HorizontalCacheLengthProperty);
			}
			set
			{
				this.SetValue(HorizontalCacheLengthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush Background
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(BackgroundProperty);
			}
			set
			{
				this.SetValue(BackgroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ElementAnimator Animator
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ElementAnimator)this.GetValue(AnimatorProperty);
			}
			set
			{
				this.SetValue(AnimatorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.ItemsSourceView ItemsSourceView
		{
			get
			{
				throw new global::System.NotImplementedException("The member ItemsSourceView ItemsRepeater.ItemsSourceView is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AnimatorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Animator), typeof(global::Microsoft.UI.Xaml.Controls.ElementAnimator), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ElementAnimator)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty BackgroundProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Background), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalCacheLengthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalCacheLength), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemTemplate), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ItemsSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ItemsSource), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LayoutProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Layout), typeof(global::Microsoft.UI.Xaml.Controls.Layout), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Layout)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalCacheLengthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalCacheLength), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ItemsRepeater() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsRepeater", "ItemsRepeater.ItemsRepeater()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsRepeater()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSourceView.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.Layout.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.Layout.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.Animator.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.Animator.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.HorizontalCacheLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.HorizontalCacheLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.VerticalCacheLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.VerticalCacheLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.Background.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.Background.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int GetElementIndex( global::Microsoft.UI.Xaml.UIElement element)
		{
			throw new global::System.NotImplementedException("The member int ItemsRepeater.GetElementIndex(UIElement element) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement TryGetElement( int index)
		{
			throw new global::System.NotImplementedException("The member UIElement ItemsRepeater.TryGetElement(int index) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement GetOrCreateElement( int index)
		{
			throw new global::System.NotImplementedException("The member UIElement ItemsRepeater.GetOrCreateElement(int index) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ElementPrepared.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ElementPrepared.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ElementClearing.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ElementClearing.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ElementIndexChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ElementIndexChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.LayoutProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.AnimatorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.HorizontalCacheLengthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.VerticalCacheLengthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ItemsRepeater.BackgroundProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ItemsRepeater, global::Microsoft.UI.Xaml.Controls.ItemsRepeaterElementClearingEventArgs> ElementClearing
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsRepeater", "event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementClearingEventArgs> ItemsRepeater.ElementClearing");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsRepeater", "event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementClearingEventArgs> ItemsRepeater.ElementClearing");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ItemsRepeater, global::Microsoft.UI.Xaml.Controls.ItemsRepeaterElementIndexChangedEventArgs> ElementIndexChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsRepeater", "event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementIndexChangedEventArgs> ItemsRepeater.ElementIndexChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsRepeater", "event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementIndexChangedEventArgs> ItemsRepeater.ElementIndexChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ItemsRepeater, global::Microsoft.UI.Xaml.Controls.ItemsRepeaterElementPreparedEventArgs> ElementPrepared
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsRepeater", "event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementPreparedEventArgs> ItemsRepeater.ElementPrepared");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ItemsRepeater", "event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementPreparedEventArgs> ItemsRepeater.ElementPrepared");
			}
		}
		#endif
	}
}
