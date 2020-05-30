using AutoDetailsFirmaDAL.Entities;
using FluentValidation;

namespace AutoDetailsFirmaBLL.Validation
{
    public class ProviderValidator : AbstractValidator<Provider>
    {
        public ProviderValidator()
        {
            RuleFor(x => x.ProviderName).MaximumLength(20).NotEmpty().WithMessage("Будь-ласка уточніть назву Постачальника (Максимум 20 символів)");
            RuleFor(x => x.ProviderAdress).MaximumLength(50).NotEmpty().WithMessage("Будь-ласка уточніть адресу Постачальнка (Максимум 50 символів)");
            RuleFor(x => x.ProviderPhone).NotEmpty().WithMessage("Будь-ласка вкажіть Телефон ");
        }
    }
}
