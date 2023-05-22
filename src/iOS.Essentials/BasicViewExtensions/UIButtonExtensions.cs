using System.Runtime.Versioning;

namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIButtonExtensions
{
    public static T SetImage<T>(this T button, UIImage? image, UIControlState forState = UIControlState.Normal) where T : UIButton
    {
        button.SetImage(image, forState);
        return button;
    }

    public static T SetImage<T>(this T button, SfSymbol sfSymbol, UIImageSymbolConfiguration? configuration = default, UIControlState forState = UIControlState.Normal) where T : UIButton
        => SetImage(button, sfSymbol.ToUIImage(configuration), forState);

    public static T SetImage<T>(this T button, SfSymbol sfSymbol, UIImageSymbolWeight weight, UIControlState forState = UIControlState.Normal) where T : UIButton
        => SetImage(button, sfSymbol.ToUIImage(weight), forState);

    public static T SetTitle<T>(this T button, string title, UIControlState forState = UIControlState.Normal) where T : UIButton
    {
        button.SetTitle(title, forState);
        return button;
    }

    public static T SetTitleColor<T>(this T button, UIColor? color, UIControlState forState = UIControlState.Normal) where T : UIButton
    {
        button.SetTitleColor(color, forState);
        return button;
    }

    public static T SetFont<T>(this T button, UIFont value) where T : UIButton
    {
        button.TitleLabel.Font = value;
        return button;
    }

    public static T SetFont<T>(this T textView, UIFontDescriptor font, nfloat pointOfSize = default) where T : UIButton
    {
        textView.TitleLabel.Font = UIFont.FromDescriptor(font, pointOfSize);
        return textView;
    }

    public static T SetFont<T>(this T textView, UIFontDescriptor font, UIFontDescriptorSymbolicTraits traits, nfloat pointOfSize = default) where T : UIButton
        => textView.SetFont(font.CreateWithTraits(traits), pointOfSize);

    public static T SetFontAsBold<T>(this T textView, UIFontDescriptor font, nfloat pointOfSize = default) where T : UIButton
        => textView.SetFont(font, UIFontDescriptorSymbolicTraits.Bold, pointOfSize);

    [SupportedOSPlatform("ios14.0")]
    public static T MakeMenuButton<T>(this T button, UIMenu? menu = default) where T : UIButton
    {
        menu ??= UIMenu.Create(Array.Empty<UIMenuElement>()); //Set a placeholder menu. The menu won't show if UIButton.Menu is null;

        button.ShowsMenuAsPrimaryAction = true;
        button.Menu = menu;
        return button;
    }
}
