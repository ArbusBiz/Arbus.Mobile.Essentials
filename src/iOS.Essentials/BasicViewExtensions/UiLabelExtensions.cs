using System.Runtime.Versioning;

namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UILabelExtensions
{
    public static T SetText<T>(this T textView, string? value) where T : UILabel
    {
        textView.Text = value;
        return textView;
    }

    public static T SetFont<T>(this T textView, UIFont font) where T : UILabel
    {
        textView.Font = font;
        return textView;
    }

    public static T SetFont<T>(this T textView, UIFontDescriptor font, nfloat pointOfSize = default) where T : UILabel
    {
        textView.Font = UIFont.FromDescriptor(font, pointOfSize);
        return textView;
    }

    public static T SetFont<T>(this T textView, UIFontDescriptor font, UIFontDescriptorSymbolicTraits traits, nfloat pointOfSize = default) where T : UILabel
        => textView.SetFont(font.CreateWithTraits(traits), pointOfSize);

    public static T SetFontAsBold<T>(this T textView, UIFontDescriptor font, nfloat pointOfSize = default) where T : UILabel
        => textView.SetFont(font, UIFontDescriptorSymbolicTraits.Bold, pointOfSize);

    public static T SetTextColor<T>(this T textView, UIColor? color) where T : UILabel
    {
        textView.TextColor = color;
        return textView;
    }

    public static T SetTextAlignment<T>(this T textView, UITextAlignment textAlignment) where T : UILabel
    {
        textView.TextAlignment = textAlignment;
        return textView;
    }

    public static T AdjustFontSizeToFitWidth<T>(this T textView, bool value = true) where T : UILabel
    {
        textView.AdjustsFontSizeToFitWidth = value;
        return textView;
    }

    [UnsupportedOSPlatform("maccatalyst6.0")]
    public static T SetMinimumFontSize<T>(this T textView, float minimumFontSize) where T : UILabel
    {
        textView.MinimumFontSize = minimumFontSize;
        return textView;
    }

    public static T SetLines<T>(this T textView, nint linesCount) where T : UILabel
    {
        textView.Lines = linesCount;
        return textView;
    }

    public static T SetLinesUnlimited<T>(this T textView) where T : UILabel
        => textView.SetLines(0);

    public static T SetLineBreakMode<T>(this T textView, UILineBreakMode breakMode) where T : UILabel
    {
        textView.LineBreakMode = breakMode;
        return textView;
    }
}