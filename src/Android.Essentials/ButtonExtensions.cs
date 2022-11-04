namespace Arbus.Android.Essentials;

public static class ButtonExtensions
{
    public static Button SetText(this Button button, string value)
    {
        button.Text = value;
        return button;
    }
}