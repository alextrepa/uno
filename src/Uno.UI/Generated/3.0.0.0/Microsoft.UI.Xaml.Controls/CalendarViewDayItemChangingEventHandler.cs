#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void CalendarViewDayItemChangingEventHandler(global::Microsoft.UI.Xaml.Controls.CalendarView @sender, global::Microsoft.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs @e);
	#endif
}
