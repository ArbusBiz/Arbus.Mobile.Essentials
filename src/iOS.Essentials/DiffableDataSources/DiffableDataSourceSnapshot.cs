namespace Arbus.iOS.Essentials.DiffableDataSources;

public class DiffableDataSourceSnapshot<TSection, TItem> : NSDiffableDataSourceSnapshot<DataSourceIdentifierType<TSection>, DataSourceIdentifierType<TItem>>
    where TSection : class
    where TItem : class
{
    public void AppendSections(IEnumerable<TSection> sections)
    {
        AppendSections(ConvertToDataSourceIdentifierType(sections));
    }

    public void AppendItems(IEnumerable<TItem> items, TSection section)
    {
        AppendItems(items, DataSourceIdentifierType.Create(section));
    }

    public void AppendItems(IEnumerable<TItem> items, DataSourceIdentifierType<TSection> section)
    {
        AppendItems(ConvertToDataSourceIdentifierType(items), section);
    }

    private static DataSourceIdentifierType<T>[] ConvertToDataSourceIdentifierType<T>(IEnumerable<T> sections) where T : class
        => sections.Select(DataSourceIdentifierType.Create).ToArray();
}