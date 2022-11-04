using Android.OS;

namespace Arbus.Android.Essentials;

public static class TextViewExtensions
{
    public static TextView SetText(this TextView textView, string value)
    {
        textView.Text = value;
        return textView;
    }

    public static TextView TextAppearance(this TextView textView, int resourceTextAppearance)
    {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            textView.SetTextAppearance(resourceTextAppearance);
        else
#pragma warning disable CS0618 // Type or member is obsolete
            textView.SetTextAppearance(Application.Context, resourceTextAppearance);
#pragma warning restore CS0618 // Type or member is obsolete
        return textView;
    }
}
