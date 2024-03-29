﻿namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UITableViewExtensions
{
    public static T SetSource<T>(this T tableView, Func<T, UITableViewSource> sourceFactory) where T : UITableView
    {
        tableView.Source = sourceFactory(tableView);
        return tableView;
    }

    public static T SetDataSource<T>(this T tableView, Func<T, IUITableViewDataSource> sourceFactory) where T : UITableView
    {
        tableView.DataSource = sourceFactory(tableView);
        return tableView;
    }

    public static T RegisterClassForRow<T>(this T tableView, Type row, string identifier) where T : UITableView
    {
        tableView.RegisterClassForCellReuse(row, identifier);
        return tableView;
    }

    public static T RegisterClassForHeaderFooter<T>(this T tableView, Type headerFooter, string identifier) where T : UITableView
    {
        tableView.RegisterClassForHeaderFooterViewReuse(headerFooter, identifier);
        return tableView;
    }

    public static T SetSeparatorStyle<T>(this T tableView, UITableViewCellSeparatorStyle value) where T : UITableView
    {
        tableView.SeparatorStyle = value;
        return tableView;
    }

    public static T SetFooterView<T>(this T tableView, UIView value) where T : UITableView
    {
        tableView.TableFooterView = value;
        return tableView;
    }

    public static T SetSeparatorInset<T>(this T tableView, UIEdgeInsets value) where T : UITableView
    {
        tableView.SeparatorInset = value;
        return tableView;
    }

    public static T SetMultipleSelection<T>(this T tableView, bool value = true) where T : UITableView
    {
        tableView.AllowsMultipleSelection = value;
        return tableView;
    }

    public static T SetSectionHeaderTopPadding<T>(this T tableView, nfloat value = default) where T : UITableView
    {
#if IOS
        if (OperatingSystem.IsIOSVersionAtLeast(15))
#else
        if (OperatingSystem.IsMacCatalystVersionAtLeast(15))
#endif
            tableView.SectionHeaderTopPadding = value;
        return tableView;
    }

    public static T SetAllowSelection<T>(this T tableView, bool value) where T : UITableView
    {
        tableView.AllowsSelection = value;
        return tableView;
    }

    public static T SetSeparatorColor<T>(this T tableView, UIColor? color) where T : UITableView
    {
        tableView.SeparatorColor = color;
        return tableView;
    }

    public static T SetScrollEnabled<T>(this T tableView, bool value) where T : UITableView
    {
        tableView.ScrollEnabled = value;
        return tableView;
    }

    public static T SetDelegate<T>(this T tableView, Func<UITableViewDelegate> delegateFactory) where T : UITableView
    {
        tableView.Delegate = delegateFactory();
        return tableView;
    }

    public static T? CellAt<T>(this UITableView tableView, NSIndexPath indexPath) where T : UITableViewCell
    {
        return (T?)tableView.CellAt(indexPath);
    }

    public static T RequiredCellAt<T>(this UITableView tableView, NSIndexPath indexPath) where T : UITableViewCell
    {
        return tableView.CellAt<T>(indexPath) ?? throw new Exception(
                $"No cell exists at section '{indexPath.Section}' and row '{indexPath.Row}'.");
    }
}
