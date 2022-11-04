namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIContextualActionExtensions
{
    public static UIContextualAction SetImage(this UIContextualAction action, UIImage? image)
    {
        action.Image = image;
        return action;
    }

    public static UIContextualAction BackgroundColor(this UIContextualAction action, UIColor? color)
    {
        action.BackgroundColor = color;
        return action;
    }
}