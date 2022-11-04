// AdvancedFluentLayoutExtensions.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace Arbus.iOS.Essentials.AutoLayout;

public static class AdvancedFluentLayoutExtensions
{
    private const float _defaultScale = 1;

    public static FluentLayout AtTopOf(this UIView view, UIView parentView, nfloat? margin = null) =>
        view.Top().EqualTo().TopOf(parentView).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtTopOfSafeArea(this UIView view, UIView parentView, nfloat? margin = null) =>
        view.Top().EqualTo().TopOf(parentView.SafeAreaLayoutGuide).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtLeftOf(this UIView view, UIView parentView, nfloat? margin = null) =>
        view.Left().EqualTo().LeftOf(parentView).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtLeftOfSafeArea(this UIView view, UIView parentView, nfloat? margin = null) =>
        view.Left().EqualTo().LeftOf(parentView.SafeAreaLayoutGuide).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtRightOf(this UIView view, UIView parentView, nfloat? margin = null) =>
        view.Right().EqualTo().RightOf(parentView).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtRightOfSafeArea(this UIView view, UIView parentView, nfloat? margin = null) =>
        view.Right().EqualTo().RightOf(parentView.SafeAreaLayoutGuide).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtBottomOf(this UIView view, UIView parentView, nfloat? margin = null) =>
        view.Bottom().EqualTo().BottomOf(parentView).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtBottomOfSafeArea(this UIView view, UIView parentView, nfloat? margin = null) =>
        view.Bottom().EqualTo().BottomOf(parentView.SafeAreaLayoutGuide).Minus(margin.GetValueOrDefault());

    public static FluentLayout AtLeadingOf(this UIView view, UIView parentView, nfloat? margin = null) =>
    view.Leading().EqualTo().LeadingOf(parentView).Plus(margin.GetValueOrDefault());

    public static FluentLayout AtTrailingOf(this UIView view, UIView parentView, nfloat? margin = null) =>
    view.Trailing().EqualTo().TrailingOf(parentView).Minus(margin.GetValueOrDefault());

    public static FluentLayout Below(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Top().EqualTo().BottomOf(previous).Plus(margin.GetValueOrDefault());

    public static FluentLayout Above(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Bottom().EqualTo().TopOf(previous).Minus(margin.GetValueOrDefault());

    public static FluentLayout WithSameLeft(this UIView view, UIView previous) => view.Left().EqualTo().LeftOf(previous);

    public static FluentLayout WithSameTop(this UIView view, UIView previous) => view.Top().EqualTo().TopOf(previous);

    public static FluentLayout WithSameCenterX(this UIView view, UIView previous) => view.CenterX().EqualTo().CenterXOf(previous);

    public static FluentLayout WithSameCenterY(this UIView view, UIView previous) => view.CenterY().EqualTo().CenterYOf(previous);

    public static FluentLayout WithSameRight(this UIView view, UIView previous) => view.Right().EqualTo().RightOf(previous);

    public static FluentLayout WithSameWidth(this UIView view, UIView previous) => view.Width().EqualTo().WidthOf(previous);

    public static FluentLayout WithSameBottom(this UIView view, UIView previous) => view.Bottom().EqualTo().BottomOf(previous);

    public static FluentLayout WithSameLeading(this UIView view, UIView previous) => view.Leading().EqualTo().LeadingOf(previous);

    public static FluentLayout WithSameTrailing(this UIView view, UIView previous) => view.Trailing().EqualTo().TrailingOf(previous);

    public static FluentLayout WithRelativeWidth(this UIView view, UIView previous, nfloat? scale = null) =>
        view.Width().EqualTo().WidthOf(previous).WithMultiplier(scale.GetValueOrDefault(_defaultScale));

    public static FluentLayout WithSameHeight(this UIView view, UIView previous) => view.Height().EqualTo().HeightOf(previous);

    public static FluentLayout WithRelativeHeight(this UIView view, UIView previous, nfloat? scale = null) =>
        view.Height().EqualTo().HeightOf(previous).WithMultiplier(scale.GetValueOrDefault(_defaultScale));

    public static FluentLayout ToRightOf(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Left().EqualTo().RightOf(previous).Plus(margin.GetValueOrDefault());

    public static FluentLayout ToLeftOf(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Right().EqualTo().LeftOf(previous).Minus(margin.GetValueOrDefault());

    public static FluentLayout ToTrailingOf(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Leading().EqualTo().TrailingOf(previous).Plus(margin.GetValueOrDefault());

    public static FluentLayout ToLeadingOf(this UIView view, UIView previous, nfloat? margin = null) =>
    view.Trailing().EqualTo().LeadingOf(previous).Minus(margin.GetValueOrDefault());

    public static FluentLayout ToLeftMargin(this UIView view, UIView previous) =>
        view.Leading().EqualTo().LeadingMarginOf(previous);

    public static FluentLayout ToRightMargin(this UIView view, UIView previous) =>
        view.Trailing().EqualTo().TrailingMarginOf(previous);

    public static FluentLayout ToTopMargin(this UIView view, UIView previous) =>
        view.Top().EqualTo().TopMarginOf(previous);

    public static FluentLayout ToBottomMargin(this UIView view, UIView previous) =>
        view.Bottom().EqualTo().BottomMarginOf(previous);

    public static FluentLayout ToLeftOfCenterOf(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Right().EqualTo().CenterXOf(previous).Minus(margin.GetValueOrDefault(0));

    public static FluentLayout ToRightOfCenterOf(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Left().EqualTo().CenterXOf(previous).Plus(margin.GetValueOrDefault(0));

    public static FluentLayout AboveCenterOf(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Bottom().EqualTo().CenterYOf(previous).Minus(margin.GetValueOrDefault(0));

    public static FluentLayout BelowCenterOf(this UIView view, UIView previous, nfloat? margin = null) =>
        view.Top().EqualTo().CenterYOf(previous).Plus(margin.GetValueOrDefault(0));

    public static IEnumerable<FluentLayout> FullWidthOf(this UIView view, UIView parent, nfloat? margin = null)
    {
        var marginValue = margin.GetValueOrDefault();
        return new List<FluentLayout>
        {
            view.AtLeftOf(parent, marginValue).WithIdentifier("Left"),
            view.AtRightOf(parent, marginValue).WithIdentifier("Right")
        };
    }

    public static IEnumerable<FluentLayout> FullHeightOf(this UIView view, UIView parent, nfloat? margin = null)
    {
        var marginValue = margin.GetValueOrDefault();
        return new List<FluentLayout>
        {
            view.AtTopOf(parent, marginValue).WithIdentifier("Top"),
            view.AtBottomOf(parent, marginValue).WithIdentifier("Bottom")
        };
    }

    public static IEnumerable<FluentLayout> FullSizeOf(this UIView view, UIView parent, nfloat? margin = null) =>
        view.FullSizeOf(parent, new Margins((float)margin.GetValueOrDefault()));

    public static IEnumerable<FluentLayout> FullSizeOf(this UIView view, UIView parent, Margins margins)
    {
        margins ??= new Margins();
        return new List<FluentLayout>
        {
            view.AtTopOf(parent, margins.Top).WithIdentifier("Top"),
            view.AtBottomOf(parent, margins.Bottom).WithIdentifier("Bottom"),
            view.AtLeftOf(parent, margins.Left).WithIdentifier("Left"),
            view.AtRightOf(parent, margins.Right).WithIdentifier("Right")
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
      float[]? childrenLeftMargins = null,
      float[]? childrenTopMargins = null,
      float[]? childrenRightMargins = null,
      float marginMultiplier = 1f,
      params UIView[] views)
    {
        string str1 = default!;
        margins = margins ?? new Margins();
        List<FluentLayout> fluentLayoutList = new List<FluentLayout>();
        int length = views.Length;
        for (int index = 0; index < length; ++index)
        {
            UIView view = views[index];
            string str2 = string.Format("{0}-{1}-", parentView.AccessibilityIdentifier ?? "VerticalStackPanel", view.AccessibilityIdentifier ?? index.ToString());
            float element1 = childrenLeftMargins?.ElementAtOrDefault(index) ?? default;
            float constant = Math.Max(margins.Left, element1) * marginMultiplier;
            fluentLayoutList.Add(view.Left().EqualTo().LeftOf(parentView).Plus((nfloat)constant).WithIdentifier(str2 + "Left"));
            float element2 = childrenRightMargins?.ElementAtOrDefault(index) ?? default;
            float num = Math.Max(margins.Right, element2) * marginMultiplier;
            fluentLayoutList.Add(view.Width().EqualTo().WidthOf(parentView).Minus((nfloat)(num + constant)).WithIdentifier(str2 + "Width"));
            float element3 = childrenTopMargins?.ElementAtOrDefault(index) ?? default;
            fluentLayoutList.Add(index == 0 ? view.Top().EqualTo().TopOf(parentView).Plus((nfloat)(Math.Max(margins.Top, element3) * marginMultiplier)).WithIdentifier(str2 + "Top") : view.Top().EqualTo().BottomOf(views[index - 1]).Plus((nfloat)(Math.Max(margins.VSpacing, element3) * marginMultiplier)).WithIdentifier(str2 + "Top"));
            str1 = str2;
        }
        if (parentView is UIScrollView)
            fluentLayoutList.Add(views[views.Length - 1].Bottom().EqualTo().BottomOf(parentView).Minus((nfloat)(margins.Bottom * marginMultiplier)).WithIdentifier(str1 + "Bottom"));
        return fluentLayoutList;
    }
}