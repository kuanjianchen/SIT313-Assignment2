using FluentValidation;
namespace Xaminals.Models
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotNull().Length(3, 20);
            RuleFor(x => x.PhoneNumber).NotNull().MinimumLength(8);
            RuleFor(x => x.Email).NotNull().EmailAddress().WithMessage("Invalid Email.");
            RuleFor(x => x.Password).NotNull().Length(8);
            RuleFor(x => x.ConfirmPassword).NotNull().Equal(x => x.Password);
        }
    }


    public class LoginUserValidator : AbstractValidator<User>
    {
        public LoginUserValidator()
        {
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.Password).NotNull();
        }
    }
}
