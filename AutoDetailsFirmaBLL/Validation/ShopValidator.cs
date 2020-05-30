using AutoDetailsFirmaDAL.Entities;
using FluentValidation;

namespace AutoDetailsFirmaBLL.Validation
{
    public class ShopValidator : AbstractValidator<Shop>
    {
        public ShopValidator()
        {
            RuleFor(x => x.ArticleOfShop).NotEmpty().Length(7).WithMessage("Будь-ласка уточніть артикул Магазину (Повинно бути 7 символів)");
            RuleFor(x => x.PriceOfShop).NotEmpty().LessThanOrEqualTo(1000000).WithMessage("Будь-ласка уточніть ціну для Магазину (Маскимум 1 000 000)");
            RuleFor(x => x.NameOfShop).MaximumLength(20).NotEmpty().WithMessage("Будь-ласка уточніть назву Магазину (Максимум 20 символів)");

        }
    }
}
