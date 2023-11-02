namespace Arbus.iOS.Essentials.BasicViewExtensions;

public static class NSLayoutConstraintExtensions
{
    public static NSLayoutConstraint Activate(this NSLayoutConstraint constraint)
    {
        constraint.Active = true;
        return constraint;
    }
    
    public static NSLayoutConstraint Deactivate(this NSLayoutConstraint constraint)
    {
        constraint.Active = false;
        return constraint;
    }

    public static NSLayoutConstraint SetConstant(this NSLayoutConstraint view, nfloat constant)
    {
        view.Constant = constant;
        return view;
    }
}
