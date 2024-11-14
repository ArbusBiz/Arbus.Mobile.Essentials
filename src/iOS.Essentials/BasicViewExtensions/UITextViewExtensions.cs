namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UITextViewExtensions
{
    public static T SetTextColor<T>(this T textView, UIColor color) where T : UITextView
    {
        textView.TextColor = color;
        return textView;
    }

    public static T SetFont<T>(this T textView, UIFont font) where T : UITextView
    {
        textView.Font = font;
        return textView;
    }
    
    public static T SetTextAlignment<T>(this T textView, UITextAlignment textAlignment) where T : UITextView
    {
        textView.TextAlignment = textAlignment;
        return textView;
    }

    public static T SetEditable<T>(this T textView, bool editable) where T : UITextView
    {
        textView.Editable = editable;
        return textView;
    }

    public static T SetDataDetectorTypes<T>(this T textView, UIDataDetectorType dataDetectorTypes) where T : UITextView
    {
        textView.DataDetectorTypes = dataDetectorTypes;
        return textView;
    }

    public static T SetScrollEnable<T>(this T textView, bool scrollEnable) where T : UITextView
    {
        textView.ScrollEnabled = scrollEnable;
        return textView;
    }
}