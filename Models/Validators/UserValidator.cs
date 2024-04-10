using FluentValidation;
using System.Data;

namespace SimpleWebApp.Models.Validators
{
    public class UserValidator : AbstractValidator<Users>
    {
        public UserValidator()
        {
            RuleFor(rule => rule.Email)
                .NotEmpty().WithMessage("Fill email input")
                .NotNull().WithMessage("Fill email input")
                .EmailAddress().WithMessage("Write correct email address");

            RuleFor(rule => rule.Password)
                .NotEmpty().WithMessage("Fill password input")
                .NotNull().WithMessage("Fill password input")
                .MinimumLength(8).WithMessage("Password min. 8 symbol")
                .MaximumLength(30).WithMessage("Password max. 30 symbol");
        }

    }
}
