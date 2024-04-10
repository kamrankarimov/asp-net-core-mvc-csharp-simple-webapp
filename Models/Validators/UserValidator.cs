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

            RuleFor(rule => rule.Name)
                .NotEmpty().WithMessage("Fill name input")
                .NotNull().WithMessage("Fill name input");

            RuleFor(rule => rule.LastName)
                .NotEmpty().WithMessage("Fill last name input")
                .NotNull().WithMessage("Fill last name input");

            RuleFor(rule => rule.Address)
                .NotEmpty().WithMessage("Fill address input")
                .NotNull().WithMessage("Fill address input")
                .MinimumLength(8).WithMessage("Address min. 8 symbol")
                .MaximumLength(30).WithMessage("Address max. 30 symbol");;
        }

    }
}
