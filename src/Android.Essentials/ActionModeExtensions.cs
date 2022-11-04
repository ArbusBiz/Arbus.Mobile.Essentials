using Android.Views;

namespace Arbus.Android.Essentials;

public static class ActionModeExtensions
{
    public static ActionMode SetTitle(this ActionMode actionMode, string title)
    {
        actionMode.Title = title;
        return actionMode;
    }
}