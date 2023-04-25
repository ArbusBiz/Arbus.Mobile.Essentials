using System.Runtime.Versioning;

namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIBarButtonItemExtensions
{
    public static T AccessibilityIdentifier<T>(this T view, string? identifier) where T : UIBarItem
    {
        view.AccessibilityIdentifier = identifier;
        return view;
    }

    public static T SetTitle<T>(this T barItem, string? title) where T : UIBarItem
    {
        barItem.Title = title;
        return barItem;
    }

    public static T SetImage<T>(this T barItem, UIImage? image) where T : UIBarItem
    {
        barItem.Image = image;
        return barItem;
    }

    public static T SetEnabled<T>(this T barItem, bool enabled) where T : UIBarItem
    {
        barItem.Enabled = enabled;
        return barItem;
    }

    [SupportedOSPlatform("ios14.0")]
    public static T AddAction<T>(this T barItem, Action action, UIImage? image) where T : UIBarButtonItem
    {
        var uiAction = UIAction.Create(_ => action());
        uiAction.Image = image;
        barItem.PrimaryAction = uiAction;
        return barItem;
    }
}