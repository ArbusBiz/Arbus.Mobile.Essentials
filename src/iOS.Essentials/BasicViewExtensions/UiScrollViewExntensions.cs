namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UiScrollViewExntensions
{
    public static T ContentInset<T>(this T view, UIEdgeInsets value) where T : UIScrollView
    {
        view.ContentInset = value;
        return view;
    }
}