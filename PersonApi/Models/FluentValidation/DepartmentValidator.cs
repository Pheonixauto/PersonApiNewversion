using FluentValidation;
using PersonApi.ModelsDTO;

namespace PersonApi.Models.FluentValidation
{
    public class DepartmentValidator : AbstractValidator<CreateDepartmentDTO>
    {
        public DepartmentValidator()
        {
            RuleFor(m => m.LeaderId).NotNull().NotEmpty().WithMessage("Please");
            RuleFor(m => m.Name).NotNull().NotEmpty().Length(5, 50);
            RuleFor(m => m.NumberEmployee);
        }
    }
}
