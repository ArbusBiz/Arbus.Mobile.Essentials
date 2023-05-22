namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIImageViewExtensions
{
    public static T SetImage<T>(this T view, string bundleName) where T : UIImageView
    {
        return view.SetImage(UIImage.FromBundle(bundleName));
    }

    public static T SetImage<T>(this T view, SfSymbol systemImage, UIImageSymbolConfiguration? configuration = default) where T : UIImageView
        => view.SetImage(systemImage.ToUIImage(configuration));

    public static T SetImage<T>(this T view, UIImage? uIImage) where T : UIImageView
    {
        view.Image = uIImage;
        return view;
    }
}