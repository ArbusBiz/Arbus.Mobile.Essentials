namespace Arbus.iOS.Essentials.DiffableDataSources;

public static class DataSourceIdentifierType
{
    public static DataSourceIdentifierType<T> Create<T>(T csharpObject) where T : class
        => new(csharpObject);
}

public class DataSourceIdentifierType<T> : NSObject where T : class
{
    public T CSharpObject { get; }

    public DataSourceIdentifierType(T csharpObject)
    {
        CSharpObject = csharpObject;
    }

    public override nuint GetNativeHash()
      => (nuint)CSharpObject.GetHashCode();

    public override bool IsEqual(NSObject? nsObject)
      => GetNativeHash() == nsObject?.GetNativeHash();
}