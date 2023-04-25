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

    public UIImage ToUIImage(UIImageSymbolConfiguration? configuration = default)
    {
        return _fromBundle
            ? UIImage.FromBundle(_imageName, default, configuration)!
            : UIImage.GetSystemImage(_imageName, configuration)!;
    }

    public UIImage ToUIImage(UIImageSymbolWeight symbolWeight)
        => ToUIImage(UIImageSymbolConfiguration.Create(symbolWeight));

    public UIImage ToUIImage(UIFont uiFont)
        => ToUIImage(UIImageSymbolConfiguration.Create(uiFont));

    public UIImage ToUIImage(UIImageSymbolScale symbolScale)
        => ToUIImage(UIImageSymbolConfiguration.Create(symbolScale));

    public UIBarButtonItem ToUIBarButton(Action onClick)
        => new(ToUIImage(), UIBarButtonItemStyle.Plain, (_, _) => onClick());

    public static implicit operator UIImage?(SfSymbol? sfSymbol) => sfSymbol?.ToUIImage();
}