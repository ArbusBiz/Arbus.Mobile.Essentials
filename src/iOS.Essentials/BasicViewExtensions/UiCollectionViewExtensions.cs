namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class UiCollectionViewExtensions
{
    public static UICollectionView SetSource(this UICollectionView collectionView, Func<UICollectionView, UICollectionViewSource> sourceFactory)
    {
        collectionView.Source = sourceFactory(collectionView);
        return collectionView;
    }

    public static UICollectionView SetDataSource(this UICollectionView collectionView, Func<UICollectionView, IUICollectionViewDataSource> sourceFactory)
    {
        collectionView.DataSource = sourceFactory(collectionView);
        return collectionView;
    }

    public static UICollectionView RegisterCell(this UICollectionView collectionView, Type cellType, NSString key)
    {
        collectionView.RegisterClassForCell(cellType, key);
        return collectionView;
    }

    public static UICollectionView SetDelegate(this UICollectionView collectionView, Func<UICollectionViewDelegate> delegateFactory)
    {
        collectionView.Delegate = delegateFactory();
        return collectionView;
    }

    public static UICollectionView SetDelegate(this UICollectionView collectionView, Func<UICollectionView, UICollectionViewDelegate> delegateFactory)
    {
        collectionView.Delegate = delegateFactory(collectionView);
        return collectionView;
    }

    public static UICollectionView MultipleSelection(this UICollectionView collectionView, bool value = true)
    {
        collectionView.AllowsMultipleSelection = value;
        return collectionView;
    }

    public static UICollectionView AllowSelection(this UICollectionView collectionView, bool value = true)
    {
        collectionView.AllowsSelection = value;
        return collectionView;
    }

    public static UICollectionView CollectionViewLayout(this UICollectionView collectionView, UICollectionViewLayout layout, bool animated = true)
    {
        collectionView.SetCollectionViewLayout(layout, animated);
        return collectionView;
    }

    public static UICollectionView RefreshControl(this UICollectionView collectionView, UIRefreshControl? refreshControl)
    {
        collectionView.RefreshControl = refreshControl;
        return collectionView;
    }

    public static UICollectionView KeyboardDismissMode(this UICollectionView collectionView, UIScrollViewKeyboardDismissMode value)
    {
        collectionView.KeyboardDismissMode = value;
        return collectionView;
    }

    public static UICollectionView ScrollEnabled(this UICollectionView collectionView, bool value = true)
    {
        collectionView.ScrollEnabled = value;
        return collectionView;
    }

    public static UICollectionView BackgroundView(this UICollectionView collectionView, UIView value)
    {
        collectionView.BackgroundView = value;
        return collectionView;
    }

    public static UICollectionView DontShowScrollIndicators(this UICollectionView collectionView)
    {
        collectionView.ShowsVerticalScrollIndicator = collectionView.ShowsHorizontalScrollIndicator = false;
        return collectionView;
    }
}