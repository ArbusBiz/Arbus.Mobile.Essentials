using CoreAnimation;

namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIViewExtensions
{
    private const int
        _lowestPriority = 1,
        _highestPriority = 1_000;

    public static T SetFrame<T>(this T view, CGRect frame) where T : UIView
    {
        view.Frame = frame;
        return view;
    }

    public static T SetBackgroundColor<T>(this T view, UIColor? color) where T : UIView
    {
        view.BackgroundColor = color;
        return view;
    }

    public static T NoBackgroundColor<T>(this T view) where T : UIView
        => view.SetBackgroundColor(default);

    public static T SetSystemBackgroundColor<T>(this T view) where T : UIView
        => view.SetBackgroundColor(UIColor.SystemBackground);

    public static T SetOpaque<T>(this T view, bool value = true) where T : UIView
    {
        view.Opaque = value;
        return view;
    }

    public static T SetAccessibilityIdentifier<T>(this T view, string? identifier) where T : UIView
    {
        view.AccessibilityIdentifier = identifier;
        return view;
    }

    public static T AddGestureRecognizers<T>(this T view, params UIGestureRecognizer[] gestureRecognizers) where T : UIView
    {
        foreach (var gesture in gestureRecognizers)
            view.AddGestureRecognizer(gesture);
        return view;
    }

    public static T SetMultipleTouch<T>(this T view, bool value = true) where T : UIView
    {
        view.MultipleTouchEnabled = value;
        return view;
    }

    public static T SetExclusiveTouch<T>(this T collectionView, bool value = true) where T : UIView
    {
        collectionView.ExclusiveTouch = value;
        return collectionView;
    }

    public static T SetLayoutMargins<T>(this T view, UIEdgeInsets value) where T : UIView
    {
        view.LayoutMargins = value;
        return view;
    }

    public static T SetLayoutMargins<T>(this T view, nfloat top, nfloat left, nfloat bottom, nfloat right) where T : UIView
    {
        view.LayoutMargins = new(top, left, bottom, right);
        return view;
    }

    public static T AddSubviewsForAutoLayout<T>(this T view, params UIView[] value) where T : UIView
    {
        view.AddSubviews(value);
        return view.DoNotTranslateSubviewsAutoresizingMaskIntoConstraints();
    }

    public static T DoNotTranslateSubviewsAutoresizingMaskIntoConstraints<T>(this T view) where T : UIView
    {
        foreach (var subview in view.Subviews)
            subview.TranslatesAutoresizingMaskIntoConstraints = false;
        return view;
    }

    public static T AddSwipeGestureRecognizer<T>(this T view, UISwipeGestureRecognizerDirection direction, Action callback) where T : UIView
    {
        var swipeGestureRecognizer = new UISwipeGestureRecognizer(callback)
        {
            Direction = direction
        };
        view.AddGestureRecognizer(swipeGestureRecognizer);
        return view;
    }

    public static T AddTapGestureRecognizer<T>(this T view, Action callback) where T : UIView
    {
        var tapGestureRecognizer = new UITapGestureRecognizer(callback);
        return view.AddGestureRecognizers(tapGestureRecognizer);
    }

    public static UIBarButtonItem AsBarButton<T>(this T uiView) where T : UIView
        => new(uiView);

    public static T SetHidden<T>(this T uiView, bool value = true) where T : UIView
    {
        uiView.Hidden = value;
        return uiView;
    }

    public static T RoundAllCorners<T>(this T view, float cornerRadius) where T : UIView
    {
        var corners = CACornerMask.MinXMinYCorner | CACornerMask.MaxXMinYCorner | CACornerMask.MinXMaxYCorner | CACornerMask.MaxXMaxYCorner;
        return view.RoundCorners(cornerRadius, corners);
    }

    public static T RoundCorners<T>(this T view, float cornerRadius, CACornerMask? corners = null) where T : UIView
    {
        view.Layer.CornerRadius = cornerRadius;
        view.Layer.MasksToBounds = true;
        if (corners != null)
            view.Layer.MaskedCorners = corners.Value;
        return view;
    }

    public static T ClipToBounds<T>(this T button, bool value = true) where T : UIView
    {
        button.ClipsToBounds = value;
        return button;
    }

    public static T SetTintColor<T>(this T view, UIColor? color) where T : UIView
    {
        view.TintColor = color;
        return view;
    }

    public static T SetUserInteractionEnabled<T>(this T tableView, bool value = true) where T : UITableView
    {
        tableView.UserInteractionEnabled = value;
        return tableView;
    }

    public static NSLayoutConstraint FindViewConstraintInSuperviews<T>(this T view, UIView superview, NSLayoutAttribute layoutAttribute) where T : UIView
    {
        var constraint = TryFindConstraintTo(superview, view.Superview.SafeAreaLayoutGuide) ?? TryFindConstraintTo(superview, superview);
        if (constraint == null && superview.Superview != null)
            constraint = FindViewConstraintInSuperviews(view, superview.Superview, layoutAttribute);
        return constraint ?? throw new InvalidOperationException($"View does not contains {layoutAttribute} constraint");

        NSLayoutConstraint? TryFindConstraintTo(UIView superview, NSObject objectToFind)
        {
            return superview.Constraints
                .LastOrDefault(x => x.FirstAttribute == layoutAttribute && x.FirstItem?.Equals(view) is true && x.SecondItem?.Equals(objectToFind) is true);
        }
    }

    public static T SetContentMode<T>(this T view, UIViewContentMode value) where T : UIView
    {
        view.ContentMode = value;
        return view;
    }

    public static T SetBorderWidth<T>(this T view, nfloat width) where T : UIView
    {
        view.Layer.BorderWidth = width;
        return view;
    }

    public static T SetBorderColor<T>(this T view, UIColor? color) where T : UIView
    {
        view.Layer.BorderColor = color?.CGColor;
        return view;
    }

    public static T SetAlpha<T>(this T view, nfloat alpha) where T : UIView
    {
        view.Alpha = alpha;
        return view;
    }

    public static T ClearBackgroundColor<T>(this T view) where T : UIView
        => view.SetBackgroundColor(UIColor.Clear);

    public static T SetHighestContentPriority<T>(this T view, UILayoutConstraintAxis axis) where T : UIView
    {
        view
            .SetHighestContentCompressionResistancePriority(axis)
            .SetHighestContentHuggingPriority(axis);
        return view;
    }

    public static T SetLowestContentPriority<T>(this T view, UILayoutConstraintAxis axis) where T : UIView
    {
        view
            .SetLowestContentCompressionResistancePriority(axis)
            .SetLowestContentHuggingPriority(axis);
        return view;
    }

    public static T SetHighestContentCompressionResistancePriority<T>(this T view, UILayoutConstraintAxis axis) where T : UIView
    {
        view.SetContentCompressionResistancePriority(_highestPriority, axis);
        return view;
    }

    public static T SetHighestContentHuggingPriority<T>(this T view, UILayoutConstraintAxis axis) where T : UIView
    {
        view.SetContentHuggingPriority(_highestPriority, axis);
        return view;
    }

    public static T SetLowestContentCompressionResistancePriority<T>(this T view, UILayoutConstraintAxis axis) where T : UIView
    {
        view.SetContentCompressionResistancePriority(_lowestPriority, axis);
        return view;
    }

    public static T SetLowestContentHuggingPriority<T>(this T view, UILayoutConstraintAxis axis) where T : UIView
    {
        view.SetContentHuggingPriority(_lowestPriority, axis);
        return view;
    }
}