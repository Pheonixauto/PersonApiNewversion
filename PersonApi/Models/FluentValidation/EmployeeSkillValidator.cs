using FluentValidation;
using PersonApi.DTO;

namespace PersonApi.Models.FluentValidation
{
    public class EmployeeSkillValidator :AbstractValidator<CreateEmployeeSkillDTO>
    {
        public EmployeeSkillValidator()
        {
            RuleFor(x=>x.EmployId).NotEmpty().NotNull();
            RuleFor(x => x.SkillId).NotEmpty().NotNull();
            RuleFor(x => x.Rating).NotEmpty().NotNull();
        }
    }
}
