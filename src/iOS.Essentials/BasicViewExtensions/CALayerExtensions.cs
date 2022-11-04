using CoreAnimation;

namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class CALayerExtensions
{
    public static CALayer MaskToBounds(this CALayer layer, bool value = true)
    {
        layer.MasksToBounds = value;
        return layer;
    }

    public static CALayer CornerRadius(this CALayer layer, nfloat value)
    {
        layer.CornerRadius = value;
        return layer;
    }

    public static CALayer ShadowRadius(this CALayer layer, nfloat value)
    {
        layer.ShadowRadius = value;
        return layer;
    }

    public static CALayer ShadowOpacity(this CALayer layer, float value)
    {
        layer.ShadowOpacity = value;
        return layer;
    }


    public static CALayer ShadowOffset(this CALayer layer, double width, double height)
    {
        layer.ShadowOffset = new CGSize(width, height);
        return layer;
    }

    public static CALayer SetElevation(this CALayer layer, nfloat elevation)
    {
        layer.ShadowColor = UIColor.Black.CGColor;
        layer.ShadowOffset = new CGSize(0, elevation);
        layer.ShadowRadius = new nfloat(Math.Abs(elevation));
        layer.ShadowOpacity = 0.24f;
        return layer;
    }
}