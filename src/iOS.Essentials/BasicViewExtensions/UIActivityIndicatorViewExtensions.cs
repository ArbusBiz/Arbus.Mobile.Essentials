namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIActivityIndicatorViewExtensions
{
    public static T Animate<T>(this T activityIndicator) where T : UIActivityIndicatorView
    {
        activityIndicator.StartAnimating();
        return activityIndicator;
    }

    public static T SetColor<T>(this T activityIndicator, UIColor? color) where T : UIActivityIndicatorView
    {
        activityIndicator.Color = color;
        return activityIndicator;
    }
}