using System.Runtime.Versioning;

namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UIControlExtensions
{
    public static T SetEnabled<T>(this T uiControl, bool value = true) where T : UIControl
    {
        uiControl.Enabled = value;
        return uiControl;
    }

    [SupportedOSPlatform("ios14.0")]
    public static T AddAction<T>(this T uiControl, Action action, UIControlEvent events) where T : UIControl
    {
        uiControl.AddAction(UIAction.Create(a => action()), events);
        return uiControl;
    }
}
