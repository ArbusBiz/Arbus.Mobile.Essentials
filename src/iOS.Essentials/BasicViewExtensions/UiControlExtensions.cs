namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UiControlExtensions
{
    public static T SetEnabled<T>(this T uiControl, bool value = true) where T : UIControl
    {
        uiControl.Enabled = value;
        return uiControl;
    }
}