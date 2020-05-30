using AutoDetailsFirmaDAL.Entities;
using FluentValidation;

namespace AutoDetailsFirmaBLL.Validation
{
    public class RoleValidator : AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
        }
    }
}
