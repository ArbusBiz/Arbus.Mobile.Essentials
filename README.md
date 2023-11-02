# Arbus.Mobile.Essentials
Essential tools for building mobile apps

[![Build Status](https://dev.azure.com/arbus/GitHub%20Pipelines/_apis/build/status/Arbus.Mobile.Essentials?branchName=main)](https://dev.azure.com/arbus/GitHub%20Pipelines/_build/latest?definitionId=46&branchName=main)

## How top use iOS.Essentials 

### SfSymbol:

```
public static SfSymbol ChevronRight => new("chevron.right");
public static SfSymbol ChevronLeft => new("chevron.left");

ChevronRight.ToUiImage(UIImageSymbolWeight.Medium);

_imageView = new UIImageView()
    .Image(SfSymbols.ChevronRight); //implicit operator
```

### DiffableDataSource:

DiffableDataSourceSnapshot and DataSourceIdentifierType
```
DiffableDataSourceSnapshot<TSection, TItem> snapshot = new();
snapshot.AppendSections(Sections);
snapshot.AppendItems(Items, section);
```

## Downloads

The latest stable releases are available on NuGet:
- [Arbus.iOS.Essentials](https://www.nuget.org/packages/Arbus.iOS.Essentials)
- Arbus.Android.Essentials (None for now)
