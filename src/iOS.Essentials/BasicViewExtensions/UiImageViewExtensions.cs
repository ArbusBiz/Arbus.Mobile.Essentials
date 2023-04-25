namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIImageViewExtensions
{
    public static T Image<T>(this T view, string bundleName) where T : UIImageView
    {
        return view.Image(UIImage.FromBundle(bundleName));
    }

    public static T Image<T>(this T view, SfSymbol systemImage, UIImageSymbolConfiguration? configuration = default) where T : UIImageView
        => view.Image(systemImage.ToUIImage(configuration));

    public static T Image<T>(this T view, UIImage? uIImage) where T : UIImageView
    {
        view.Image = uIImage;
        return view;
    }

    public static T AspectFitContent<T>(this T view) where T : UIImageView
        => view.SetContentMode(UIViewContentMode.ScaleAspectFit);
}