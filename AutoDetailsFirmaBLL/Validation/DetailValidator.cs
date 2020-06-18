using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using FluentValidation;
namespace AutoDetailsFirmaBLL.Validation
{
    public class DetailValidator : AbstractValidator<DetailDTO>
    {
        public DetailValidator()
        {
            RuleFor(x => x.NameOfDetail).NotEmpty().Length(0, 25).WithMessage("Будь-ласка уточніть назву Деталі (Максимум 25 символів)");
            RuleFor(x => x.ArticleOfDetail).NotEmpty().Length(7).WithMessage("Будь-ласка уточніть артикул Деталі (Повинно бути 7 символів)");
            RuleFor(x => x.DataOfDetail).NotEmpty().WithMessage("Будь-ласка уточніть дату Деталі");


        }
    }
}
