// UIViewAndLayoutAttribute.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace Arbus.iOS.Essentials.AutoLayout;

public class UIViewAndLayoutAttribute
{
    public UIView View { get; }

    public NSLayoutAttribute Attribute { get; }

    public UIViewAndLayoutAttribute(UIView view, NSLayoutAttribute attribute)
    {
        Attribute = attribute;
        View = view;
    }

    public FluentLayout EqualTo(nfloat constant = default)
        => new(View, Attribute, NSLayoutRelation.Equal, constant);

    public FluentLayout GreaterThanOrEqualTo(nfloat constant = default)
        => new(View, Attribute, NSLayoutRelation.GreaterThanOrEqual, constant);

    public FluentLayout LessThanOrEqualTo(nfloat constant = default)
        => new(View, Attribute, NSLayoutRelation.LessThanOrEqual, constant);
}