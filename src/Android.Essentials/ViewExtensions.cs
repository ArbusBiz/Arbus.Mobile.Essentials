using Android.Views;
using Android.Views.InputMethods;

namespace Arbus.Android.Essentials;

public static class ViewExtensions
{
    public static T OnTouchListener<T>(this T view, View.IOnTouchListener listener) where T : View
    {
        view.SetOnTouchListener(listener);
        return view;
    }

    public static TView ShowSoftInput<TView>(this TView view, InputMethodManager inputMethodManager, ShowFlags flags = ShowFlags.Implicit) where TView : View
    {
        inputMethodManager.ShowSoftInput(view, flags);
        return view;
    }
}