using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using FluentValidation;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Validators
{
    public class AppUserValidator : AbstractValidator<AppUser>
    {
        public AppUserValidator()
        {
            RuleFor(a => a.FirstName).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage("İsim Boş Olamaz!");
            RuleFor(a => a.LastName).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage("Soyisim Boş Olamaz!");
            RuleFor(a => a.FirstName).MaximumLength(100).WithMessage("100 Karakterden Uzun Olamaz!");
            RuleFor(a => a.LastName).MaximumLength(100).WithMessage("100 Karakterden Uzun Olamaz!");
        }
    }
}
