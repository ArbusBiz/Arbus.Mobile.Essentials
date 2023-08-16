// AdvancedFluentLayoutExtensions.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using ObjCRuntime;

namespace Arbus.iOS.Essentials.AutoLayout;

public static class AdvancedFluentLayoutExtensions
{
    private const float _defaultScale = 1;

    public static FluentLayout AtLeading(this UIView view, nfloat? margin = null)
        => view.Leading().EqualTo().LeadingOf(view.Superview).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtTrailing(this UIView view, nfloat? margin = null)
        => view.Trailing().EqualTo().TrailingOf(view.Superview).Minus(margin.GetValueOrDefault());

    public static FluentLayout Below(this UIView view, UIView view2, nfloat? margin = null)
        => view.Top().EqualTo().BottomOf(view2).Plus(margin.GetValueOrDefault());

    public static FluentLayout Above(this UIView view, UIView view2, nfloat? margin = null)
        => view.Bottom().EqualTo().TopOf(view2).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtTop(this UIView view, nfloat? margin = null)
        => view.WithSameTop(view.Superview, margin);

    public static FluentLayout WithSameTop(this UIView view, UIView view2, nfloat? margin = null)
        => view.Top().EqualTo().TopOf(view2).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtTopOfSafeArea(this UIView view, nfloat? margin = null)
        => view.Top().EqualTo().TopOf(view.Superview.SafeAreaLayoutGuide).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtLeft(this UIView view, nfloat? margin = null)
        => view.WithSameLeft(view.Superview, margin);

    public static FluentLayout WithSameLeft(this UIView view, UIView view2, nfloat? margin = null)
        => view.Left().EqualTo().LeftOf(view2).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtLeftOfSafeArea(this UIView view, nfloat? margin = null)
        => view.Left().EqualTo().LeftOf(view.Superview.SafeAreaLayoutGuide).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtRight(this UIView view, nfloat? margin = null)
        => view.WithSameRight(view.Superview, margin);

    public static FluentLayout WithSameRight(this UIView view, UIView view2, nfloat? margin = null)
        => view.Right().EqualTo().RightOf(view2).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtRightOfSafeArea(this UIView view, nfloat? margin = null)
        => view.Right().EqualTo().RightOf(view.Superview.SafeAreaLayoutGuide).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtBottom(this UIView view, nfloat? margin = null)
        => view.WithSameBottom(view.Superview, margin);

    public static FluentLayout WithSameBottom(this UIView view, UIView view2, nfloat? margin = null)
        => view.Bottom().EqualTo().BottomOf(view2).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtBottomOfSafeArea(this UIView view, nfloat? margin = null) =>
        view.Bottom().EqualTo().BottomOf(view.Superview.SafeAreaLayoutGuide).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtCenterX(this UIView view)
        => view.WithSameCenterX(view.Superview);

    public static FluentLayout WithSameCenterX(this UIView view, UIView view2)
        => view.CenterX().EqualTo().CenterXOf(view2);

    public static FluentLayout AtCenterY(this UIView view)
        => view.WithSameCenterY(view.Superview);

    public static FluentLayout WithSameCenterY(this UIView view, UIView view2)
        => view.CenterY().EqualTo().CenterYOf(view2);

    public static FluentLayout MatchWidth(this UIView view)
        => view.WithSameWidth(view.Superview);

    public static FluentLayout WithSameWidth(this UIView view, UIView view2)
        => view.Width().EqualTo().WidthOf(view2);

    public static FluentLayout WithRelativeWidth(this UIView view, UIView view2, nfloat? scale = null)
        => view.Width().EqualTo().WidthOf(view2).WithMultiplier(scale.GetValueOrDefault(_defaultScale));

    public static FluentLayout MatchHeight(this UIView view)
        => view.WithSameHeight(view.Superview);

    public static FluentLayout WithSameHeight(this UIView view, UIView view2)
        => view.Height().EqualTo().HeightOf(view2);

    public static FluentLayout WithRelativeHeight(this UIView view, UIView view2, nfloat? scale = null) =>
        view.Height().EqualTo().HeightOf(view2).WithMultiplier(scale.GetValueOrDefault(_defaultScale));

    public static FluentLayout ToRightOf(this UIView view, UIView view2, nfloat? margin = null) =>
        view.Left().EqualTo().RightOf(view2).Plus(margin.GetValueOrDefault());

    public static FluentLayout ToLeftOf(this UIView view, UIView view2, nfloat? margin = null) =>
        view.Right().EqualTo().LeftOf(view2).Minus(margin.GetValueOrDefault());

    public static FluentLayout ToTrailingOf(this UIView view, UIView view2, nfloat? margin = null) =>
        view.Leading().EqualTo().TrailingOf(view2).Plus(margin.GetValueOrDefault());

    public static FluentLayout ToLeadingOf(this UIView view, UIView view2, nfloat? margin = null) =>
    view.Trailing().EqualTo().LeadingOf(view2).Minus(margin.GetValueOrDefault());

    public static FluentLayout ToLeftMargin(this UIView view, UIView view2) =>
        view.Leading().EqualTo().LeadingMarginOf(view2);

    public static FluentLayout ToRightMargin(this UIView view, UIView view2) =>
        view.Trailing().EqualTo().TrailingMarginOf(view2);

    public static FluentLayout ToTopMargin(this UIView view, UIView view2) =>
        view.Top().EqualTo().TopMarginOf(view2);

    public static FluentLayout ToBottomMargin(this UIView view, UIView view2) =>
        view.Bottom().EqualTo().BottomMarginOf(view2);

    public static FluentLayout ToLeftOfCenterOf(this UIView view, UIView view2, nfloat? margin = null) =>
        view.Right().EqualTo().CenterXOf(view2).Minus(margin.GetValueOrDefault(0));

    public static FluentLayout ToRightOfCenterOf(this UIView view, UIView view2, nfloat? margin = null) =>
        view.Left().EqualTo().CenterXOf(view2).Plus(margin.GetValueOrDefault(0));

    public static FluentLayout AboveCenterOf(this UIView view, UIView view2, nfloat? margin = null) =>
        view.Bottom().EqualTo().CenterYOf(view2).Minus(margin.GetValueOrDefault(0));

    public static FluentLayout BelowCenterOf(this UIView view, UIView view2, nfloat? margin = null) =>
        view.Top().EqualTo().CenterYOf(view2).Plus(margin.GetValueOrDefault(0));

    public static IEnumerable<FluentLayout> FullWidthOf(this UIView view, UIView parent, nfloat? margin = null)
    {
        var marginValue = margin.GetValueOrDefault();
        return new List<FluentLayout>
        {
            view.WithSameLeft(parent, marginValue).WithIdentifier("Left"),
            view.WithSameRight(parent, marginValue).WithIdentifier("Right")
        };
    }

    public static IEnumerable<FluentLayout> FullHeightOf(this UIView view, UIView parent, nfloat? margin = null)
    {
        var marginValue = margin.GetValueOrDefault();
        return new List<FluentLayout>
        {
            view.WithSameTop(parent, marginValue).WithIdentifier("Top"),
            view.WithSameBottom(parent, marginValue).WithIdentifier("Bottom")
        };
    }

    public static IEnumerable<FluentLayout> FullSizeOf(this UIView view, UIView parent, nfloat? margin = null) =>
        view.FullSizeOf(parent, new Margins(margin.GetValueOrDefault()));

    public static IEnumerable<FluentLayout> FullSizeOf(this UIView view, UIView parent, Margins margins)
    {
        margins ??= new Margins();
        return new List<FluentLayout>
        {
            view.WithSameTop(parent, margins.Top).WithIdentifier("Top"),
            view.WithSameBottom(parent, margins.Bottom).WithIdentifier("Bottom"),
            view.WithSameLeft(parent, margins.Left).WithIdentifier("Left"),
            view.WithSameRight(parent, margins.Right).WithIdentifier("Right")
        };
    }


    public static IEnumerable<FluentLayout> VerticalStackPanelConstraints(
      this UIView parentView,
      Margins margins,
      params UIView[] views)
    {
        return parentView.AdvancedVerticalStackPanelConstraints(margins, views: views);
    }

    public static IEnumerable<FluentLayout> AdvancedVerticalStackPanelConstraints(
      this UIView parentView,
      Margins margins,
      nfloat[]? childrenLeftMargins = null,
      nfloat[]? childrenTopMargins = null,
      nfloat[]? childrenRightMargins = null,
      float marginMultiplier = 1f,
      params UIView[] views)
    {
        string str1 = default!;
        margins ??= new Margins();
        List<FluentLayout> fluentLayoutList = new List<FluentLayout>();
        int length = views.Length;
        for (int index = 0; index < length; ++index)
        {
            UIView view = views[index];
            string str2 = string.Format("{0}-{1}-", parentView.AccessibilityIdentifier ?? "VerticalStackPanel", view.AccessibilityIdentifier ?? index.ToString());
            nfloat element1 = childrenLeftMargins?.ElementAtOrDefault(index) ?? default;
            nfloat constant = NMath.Max(margins.Left, element1) * marginMultiplier;
            fluentLayoutList.Add(view.Left().EqualTo().LeftOf(parentView).Plus((nfloat)constant).WithIdentifier(str2 + "Left"));
            nfloat element2 = childrenRightMargins?.ElementAtOrDefault(index) ?? default;
            nfloat num = NMath.Max(margins.Right, element2) * marginMultiplier;
            fluentLayoutList.Add(view.Width().EqualTo().WidthOf(parentView).Minus((nfloat)(num + constant)).WithIdentifier(str2 + "Width"));
            nfloat element3 = childrenTopMargins?.ElementAtOrDefault(index) ?? default;
            fluentLayoutList.Add(index == 0 ? view.Top().EqualTo().TopOf(parentView).Plus((nfloat)(Math.Max(margins.Top, element3) * marginMultiplier)).WithIdentifier(str2 + "Top") : view.Top().EqualTo().BottomOf(views[index - 1]).Plus((nfloat)(Math.Max(margins.VSpacing, element3) * marginMultiplier)).WithIdentifier(str2 + "Top"));
            str1 = str2;
        }
        if (parentView is UIScrollView)
            fluentLayoutList.Add(views[^1].Bottom().EqualTo().BottomOf(parentView).Minus((nfloat)(margins.Bottom * marginMultiplier)).WithIdentifier(str1 + "Bottom"));
        return fluentLayoutList;
    }
}