namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UINavigationItemExtensions
{
    public static UINavigationItem SetTitle(this UINavigationItem navigationItem, string? title)
    {
        navigationItem.Title = title;
        return navigationItem;
    }

    public static UINavigationItem SetTitleView(this UINavigationItem navigationItem, UIView? view)
    {
        navigationItem.TitleView = view;
        return navigationItem;
    }

    public static UINavigationItem SetLeftItems(this UINavigationItem navigationItem, params UIBarButtonItem[] items)
    {
        navigationItem.SetLeftBarButtonItems(items, false);
        return navigationItem;
    }

    public static UINavigationItem SetRightItems(this UINavigationItem navigationItem, params UIBarButtonItem[] items)
    {
        navigationItem.SetRightBarButtonItems(items, false);
        return navigationItem;
    }

    public static UINavigationItem HideBackButton(this UINavigationItem navigationItem)
    {
        navigationItem.HidesBackButton = true;
        return navigationItem;
    }
}