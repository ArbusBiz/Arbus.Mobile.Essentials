using Android.Text;
using Android.Text.Method;

namespace Arbus.Android.Essentials;

public static class EditTextExtensions
{
    public static EditText SetHint(this EditText editText, string? value)
    {
        editText.Hint = value;
        return editText;
    }

    public static TView NoTransformationMethod<TView>(this TView view) where TView : EditText
    {
        view.TransformationMethod = default;
        return view;
    }

    public static TView TryRequestFocus<TView>(this TView view) where TView : EditText
    {
        view.RequestFocus();
        return view;
    }

    public static TView KeyListener<TView>(this TView view, IKeyListener? keyListener) where TView : EditText
    {
        view.KeyListener = keyListener;
        return view;
    }

    public static TView SetInputType<TView>(this TView view, InputTypes inputType) where TView : EditText
    {
        view.InputType = inputType;
        return view;
    }
}