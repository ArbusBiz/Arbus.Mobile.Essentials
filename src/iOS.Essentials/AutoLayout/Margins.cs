// Margins.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace Arbus.iOS.Essentials.AutoLayout;

public class Margins
{
    public nfloat Top { get; set; }

    public nfloat Bottom { get; set; }

    public nfloat Left { get; set; }

    public nfloat Right { get; set; }

    public nfloat VSpacing { get; set; }

    public nfloat HSpacing { get; set; }

    public Margins()
    {
    }

    public Margins(nfloat all)
    {
        Top = all;
        Bottom = all;
        Right = all;
        Left = all;
        VSpacing = all;
        HSpacing = all;
    }

    public Margins(nfloat allHorizontal, nfloat allVertical)
    {
        Top = allVertical;
        Bottom = allVertical;
        Right = allHorizontal;
        Left = allHorizontal;
        VSpacing = allVertical;
        HSpacing = allHorizontal;
    }

    public Margins(nfloat left, nfloat top, nfloat right, nfloat bottom, float hspacing = 0, float vspacing = 0)
    {
        Top = top;
        Bottom = bottom;
        Right = right;
        Left = left;
        VSpacing = vspacing;
        HSpacing = hspacing;
    }
}