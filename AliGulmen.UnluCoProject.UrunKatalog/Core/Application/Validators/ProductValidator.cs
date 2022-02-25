using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using FluentValidation;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(a => a.Name).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage("İsim Boş Olamaz!");
            RuleFor(a => a.PictureUrl).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage("Resim Boş Olamaz!");
            RuleFor(a => a.Description).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage("Açıklama Boş Olamaz!");
            RuleFor(a => a.ConditionId).GreaterThan(0).WithMessage("Kullanım Durumu Boş Olamaz!");
            RuleFor(a => a.CategoryId).GreaterThan(0).WithMessage("Kategori Boş Olamaz!");
            RuleFor(a => a.Name).MaximumLength(100).WithMessage("100 Karakterden Uzun Olamaz!");
            RuleFor(a => a.Description).MaximumLength(500).WithMessage("500 Karakterden Uzun Olamaz!");
            RuleFor(a => a.BuyItNowPrice).GreaterThan(0).WithMessage("Fiyat Bilgisi Girilmelidir!");
        }
    }
}
