﻿namespace Arbus.iOS.Essentials.BasicViewExtensions;

#if IOS || MACCATALYST

public static class UiToolbarExtensions
{
    public static T SetItemsAnimated<T>(this T toolbar, params UIBarButtonItem[] items) where T : UIToolbar
    {
        toolbar.SetItems(items, animated: true);
        return toolbar;
    }

    public static T BarTintColor<T>(this T toolbar, UIColor color) where T : UIToolbar
    {
        toolbar.BarTintColor = color;
        return toolbar;
    }
}

#endif