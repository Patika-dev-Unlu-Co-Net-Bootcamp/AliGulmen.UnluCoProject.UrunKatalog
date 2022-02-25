using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using FluentValidation;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Validators
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(a => a.Name).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage("İsim Boş Olamaz!");
            RuleFor(a => a.Name).MaximumLength(100).WithMessage("100 Karakterden Uzun Olamaz!");
        }
    }
}
