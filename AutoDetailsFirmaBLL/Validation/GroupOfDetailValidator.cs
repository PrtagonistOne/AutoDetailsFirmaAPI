using AutoDetailsFirmaDAL.Entities;
using FluentValidation;

namespace AutoDetailsFirmaBLL.Validation
{
    class GroupOfDetailValidator : AbstractValidator<GroupOfDetail>
    {
        public GroupOfDetailValidator()
        {
            RuleFor(x => x.ArticleOfGroupOfDetail).Length(7).NotEmpty().WithMessage("Будь-ласка уточніть артикул Групи Деталі (Повинно бути 7 символів)");
            RuleFor(x => x.PriceOfGroupOfDetail).LessThanOrEqualTo(1000000).NotEmpty().WithMessage("Будь-ласка уточніть ціну (Максимум 1 000 000)");
            RuleFor(x => x.NotesOfGroupOfDetail).NotEmpty().Length(0, 50).WithMessage("Будь-ласка уточніть Примітку Группи Деталі (Максимум 50 символів)");
            RuleFor(x => x.DataOfGroupOfDetail).NotEmpty().WithMessage("Будь-ласка уточніть дату Групи Деталі");

        }
    }
}
