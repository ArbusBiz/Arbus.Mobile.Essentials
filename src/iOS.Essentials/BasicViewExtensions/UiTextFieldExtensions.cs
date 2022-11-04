namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UiTextFieldExtensions
{
    public static UITextField SetDelegate(this UITextField textField, IUITextFieldDelegate textFieldDelegate)
    {
        textField.Delegate = textFieldDelegate;
        return textField;
    }

    public static UITextField SetKeyboardType(this UITextField textField, UIKeyboardType keyboardType)
    {
        textField.KeyboardType = keyboardType;
        return textField;
    }

    public static UITextField SetPlaceholder(this UITextField textField, string? placeholder)
    {
        textField.Placeholder = placeholder;
        return textField;
    }

    public static UITextField SetFont(this UITextField textField, UIFontDescriptor font, nfloat pointOfSize = default)
    {
        textField.Font = UIFont.FromDescriptor(font, pointOfSize);
        return textField;
    }
}