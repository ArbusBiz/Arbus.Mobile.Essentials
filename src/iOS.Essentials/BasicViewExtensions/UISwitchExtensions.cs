namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UISwitchExtensions
{
    public static UISwitch OnTintColor(this UISwitch uiSwitch, UIColor color)
    {
        uiSwitch.OnTintColor = color;
        return uiSwitch;
    }
}