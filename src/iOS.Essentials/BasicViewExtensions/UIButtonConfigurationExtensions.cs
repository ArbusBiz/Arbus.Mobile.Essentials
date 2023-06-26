using System.Runtime.Versioning;

namespace Arbus.iOS.Essentials.BasicViewExtensions;

[SupportedOSPlatform("ios15.0")]
public static class UIButtonConfigurationExtensions
{
    public static UIButtonConfiguration SetTitle(this UIButtonConfiguration configuration, string? title)
    {
        configuration.Title = title;
        return configuration;
    }

    public static UIButtonConfiguration SetSize(this UIButtonConfiguration configuration, UIButtonConfigurationSize size)
    {
        configuration.ButtonSize = size;
        return configuration;
    }

    public static UIButtonConfiguration SetBaseBackgroundColor(this UIButtonConfiguration configuration, UIColor? color)
    {
        configuration.BaseBackgroundColor = color;
        return configuration;
    }
    
    public static UIButtonConfiguration SetBaseForegroundColor(this UIButtonConfiguration configuration, UIColor? color)
    {
        configuration.BaseForegroundColor = color;
        return configuration;
    }

    public static UIButtonConfiguration SetImage(this UIButtonConfiguration configuration, UIImage? image)
    {
        configuration.Image = image;
        return configuration;
    }

    public static UIButtonConfiguration MakeOutlined(this UIButtonConfiguration configuration, UIColor strokeColor, nfloat strokeWidth, nfloat cornerRadius)
    {
        configuration.Background.StrokeWidth = strokeWidth;
        configuration.Background.StrokeColor = strokeColor;
        configuration.Background.CornerRadius = cornerRadius;
        return configuration;
    }

    public static UIButtonConfiguration SetTitleAsBold(this UIButtonConfiguration configuration, string title)
    {
        var uiFont = UIFont.BoldSystemFontOfSize(UIFont.PreferredBody.PointSize);
        configuration.AttributedTitle = new NSAttributedString(title, uiFont);
        return configuration;
    }

    public static UIButtonConfiguration RoundCorners(this UIButtonConfiguration configuration, int cornerRadius)
    {
        configuration.Background.CornerRadius = cornerRadius;
        return configuration;
    }

    public static UIButton ToUIButton(this UIButtonConfiguration configuration) => new()
    {
        Configuration = configuration
    };
}