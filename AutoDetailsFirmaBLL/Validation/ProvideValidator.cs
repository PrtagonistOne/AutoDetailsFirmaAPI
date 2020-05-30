using AutoDetailsFirmaDAL.Entities;
using FluentValidation;

namespace AutoDetailsFirmaBLL.Validation
{
    public class ProvideValidator : AbstractValidator<Provide>
    {
        public ProvideValidator()
        {
            RuleFor(x => x.PriceOfProvide).NotEmpty().LessThanOrEqualTo(1000000).WithMessage("Будь-ласка уточніть ціну Поставки (Максимум 1 000 00)");
            RuleFor(x => x.DataOfProvide).NotEmpty().WithMessage("Будь-ласка уточніть дату Поставки");
            RuleFor(x => x.ArticleOfProvide).NotEmpty().Length(7).WithMessage("Будь-ласка уточніть артикул Поставки (Повинно бути 7 символів)");

        }
    }
}
