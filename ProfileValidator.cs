using FluentValidation;

namespace PatchExample;

public class ProfileValidator : AbstractValidator<Profile>
{
    public ProfileValidator()
    {
        RuleFor(o => o.FirstName).NotEmpty();
        RuleFor(o => o.LastName).NotEmpty();
        RuleFor(o => o.Registered).LessThan(DateTime.UtcNow);
        RuleFor(o => o.Age).NotEmpty().GreaterThanOrEqualTo(18);
    }
}