﻿namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIScrollViewExtensions
{
    public static T SetContentInset<T>(this T view, UIEdgeInsets value) where T : UIScrollView
    {
        view.ContentInset = value;
        return view;
    }
}