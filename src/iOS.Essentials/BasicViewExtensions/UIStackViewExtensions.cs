﻿namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIStackViewExtensions
{
    public static UIStackView AddArrangedSubviews(this UIStackView stackView, params UIView[] subviews)
    {
        foreach (var subview in subviews)
            stackView.AddArrangedSubview(subview);
        return stackView;
    }

    public static UIStackView AddArrangedSubviewsForAutolayout(this UIStackView stackView, params UIView[] subviews)
    {
        foreach (var subview in subviews)
            stackView.AddArrangedSubview(subview);
        stackView.DoNotTranslateSubviewsAutoresizingMaskIntoConstraints();
        return stackView;
    }

    public static UIStackView SetAxis(this UIStackView stackView, UILayoutConstraintAxis constraintAxis)
    {
        stackView.Axis = constraintAxis;
        return stackView;
    }

    public static UIStackView SetDistribution(this UIStackView stackView, UIStackViewDistribution distribution)
    {
        stackView.Distribution = distribution;
        return stackView;
    }

    public static UIStackView LayoutMarginsRelativeArrangement(this UIStackView stackView, bool value = true)
    {
        stackView.LayoutMarginsRelativeArrangement = value;
        return stackView;
    }

    public static UIStackView SetSpacing(this UIStackView stackView, nfloat value)
    {
        stackView.Spacing = value;
        return stackView;
    }

    public static UIStackView SetAlignment(this UIStackView stackView, UIStackViewAlignment alignment)
    {
        stackView.Alignment = alignment;
        return stackView;
    }

    public static T SetSubviewsLowestContentPriority<T>(this T view, UILayoutConstraintAxis axis) where T : UIStackView
    {
        foreach (var subview in view.Subviews)
        {
            subview
                .SetLowestContentCompressionResistancePriority(axis)
                .SetLowestContentHuggingPriority(axis);
        }
        return view;
    }
}
