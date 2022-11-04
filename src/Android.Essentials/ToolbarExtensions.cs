using Android.Views;

namespace Arbus.Android.Essentials;

public static class ToolbarExtensions
{
    public static TView SetItemVisibility<TView>(this TView toolbar, int itemId, bool visibility) where TView : Toolbar
    {
        var itemView = toolbar.FindViewById(itemId) ?? throw new InvalidOperationException($"Menu item with id [{itemId}] doesn't exist in toolbar");
        itemView.Visibility = visibility ? ViewStates.Visible : ViewStates.Invisible;
        return toolbar;
    }

    public static TView SetNavigationButton<TView>(this TView toolbar, int icon, View.IOnClickListener listener) where TView : Toolbar
    {
        toolbar.SetNavigationIcon(icon);
        toolbar.SetNavigationOnClickListener(listener);
        return toolbar;
    }

    public static TView SetTitle<TView>(this TView toolbar, string title) where TView : Toolbar
    {
        toolbar.Title = title;
        return toolbar;
    }

    public static TView SetSubtitle<TView>(this TView toolbar, string subtitle) where TView : Toolbar
    {
        toolbar.Subtitle = subtitle;
        return toolbar;
    }
}
