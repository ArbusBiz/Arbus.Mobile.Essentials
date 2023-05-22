namespace Arbus.iOS.Essentials.DiffableDataSources;

public static class DataSourceIdentifier
{
    public static DataSourceIdentifier<T> Create<T>(T dataObject) where T : notnull
        => new(dataObject);
}

public class DataSourceIdentifier<T> : NSObject where T : notnull
{
    public T DataObject { get; }

    public DataSourceIdentifier(T dataObject)
    {
        DataObject = dataObject;
    }

    public override nuint GetNativeHash()
      => (nuint)DataObject.GetHashCode();

    public override bool IsEqual(NSObject? nsObject)
      => GetNativeHash() == nsObject?.GetNativeHash();
}