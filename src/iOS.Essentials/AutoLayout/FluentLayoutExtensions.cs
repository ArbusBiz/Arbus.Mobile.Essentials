// FluentLayoutExtensions.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace Arbus.iOS.Essentials.AutoLayout;

public static class FluentLayoutExtensions
{
    [Obsolete("Use AddSubviewsForAutoLayout. The method is to be removed in the future.")]
    public static void SubviewsDoNotTranslateAutoresizingMaskIntoConstraints(this UIView view)
    {
        foreach (var subview in view.Subviews)
            subview.TranslatesAutoresizingMaskIntoConstraints = false;
    }

    public static UIViewAndLayoutAttribute Left(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Left);

    public static UIViewAndLayoutAttribute Right(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Right);

    public static UIViewAndLayoutAttribute Top(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Top);

    public static UIViewAndLayoutAttribute Bottom(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Bottom);

    public static UIViewAndLayoutAttribute Baseline(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Baseline);

    public static UIViewAndLayoutAttribute Trailing(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Trailing);

    public static UIViewAndLayoutAttribute Leading(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Leading);

    public static UIViewAndLayoutAttribute CenterX(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.CenterX);

    public static UIViewAndLayoutAttribute CenterY(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.CenterY);

    public static UIViewAndLayoutAttribute Height(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Height);

    public static UIViewAndLayoutAttribute Width(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.Width);

    public static UIViewAndLayoutAttribute WithLayoutAttribute(this UIView view, NSLayoutAttribute attribute) => new UIViewAndLayoutAttribute(view, attribute);

    public static UIViewAndLayoutAttribute LeadingMargin(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.LeadingMargin);

    public static UIViewAndLayoutAttribute TrailingMargin(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.TrailingMargin);

    public static UIViewAndLayoutAttribute TopMargin(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.TopMargin);

    public static UIViewAndLayoutAttribute BottomMargin(this UIView view) => view.WithLayoutAttribute(NSLayoutAttribute.BottomMargin);

    public static T AddConstraints<T>(this T view, params FluentLayout[] fluentLayouts) where T : UIView
    {
        view.AddConstraints(fluentLayouts.AsEnumerable());
        return view;
    }

    public static T AddConstraints<T>(this T view, IEnumerable<FluentLayout> fluentLayouts) where T : UIView
    {
        view.AddConstraints(fluentLayouts
            .Where(fluent => fluent != null)
            .Select(fluent => fluent.Constraint.Value)
            .ToArray());
        return view;
    }

    public static void RemoveConstraints(this UIView view, params FluentLayout[] fluentLayouts) => view.RemoveConstraints(fluentLayouts.AsEnumerable());

    public static void RemoveConstraints(this UIView view, IEnumerable<FluentLayout> fluentLayouts) =>
        view.RemoveConstraints(fluentLayouts
            .Where(fluent => fluent != null)
            .Select(fluent => fluent.Constraint.Value)
            .ToArray());
}