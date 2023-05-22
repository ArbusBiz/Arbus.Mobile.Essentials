namespace Arbus.iOS.Essentials.DiffableDataSources;

public class DiffableDataSourceSnapshot<TSection, TItem> : NSDiffableDataSourceSnapshot<DataSourceIdentifier<TSection>, DataSourceIdentifier<TItem>>
    where TSection : notnull
    where TItem : notnull
{
    public void AppendSections(IEnumerable<TSection> sections)
    {
        AppendSections(ConvertToDataSourceIdentifierType(sections));
    }

    public void AppendItems(IEnumerable<TItem> items, TSection section)
    {
        AppendItems(items, DataSourceIdentifier.Create(section));
    }

    public void AppendItems(IEnumerable<TItem> items, DataSourceIdentifier<TSection> section)
    {
        AppendItems(ConvertToDataSourceIdentifierType(items), section);
    }

    private static DataSourceIdentifier<T>[] ConvertToDataSourceIdentifierType<T>(IEnumerable<T> sections) where T : notnull
    {
        return sections.Select(DataSourceIdentifier.Create).ToArray();
    }
}