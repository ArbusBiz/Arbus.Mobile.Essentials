namespace Arbus.iOS.Essentials;

public sealed class SfSymbol
{
    private readonly string _imageName;
    private readonly bool _fromBundle;

    public SfSymbol(string systemImageName, bool fromBundle = false)
    {
        _imageName = systemImageName;
        _fromBundle = fromBundle;
    }

    public UIImage ToUiImage(UIImageSymbolConfiguration? configuration = default)
    {
        return _fromBundle
            ? UIImage.FromBundle(_imageName, default, configuration)!
            : UIImage.GetSystemImage(_imageName, configuration)!;
    }

    public UIImage ToUiImage(UIImageSymbolWeight symbolWeight)
        => ToUiImage(UIImageSymbolConfiguration.Create(symbolWeight));

    public UIImage ToUiImage(UIFont uiFont)
        => ToUiImage(UIImageSymbolConfiguration.Create(uiFont));

    public UIImage ToUiImage(UIImageSymbolScale symbolScale)
        => ToUiImage(UIImageSymbolConfiguration.Create(symbolScale));

    public UIBarButtonItem ToUiBarButton(Action onClick)
        => new(ToUiImage(), UIBarButtonItemStyle.Plain, (_, _) => onClick());

    public static implicit operator UIImage?(SfSymbol? sfSymbol) => sfSymbol?.ToUiImage();
}