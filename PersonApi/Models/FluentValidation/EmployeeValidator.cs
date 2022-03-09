using FluentValidation;
using PersonApi.ModelsDTO;

namespace PersonApi.Models.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<CreateEmployeeDTO>
    {
        public EmployeeValidator()
        {
            RuleFor(x=>x.IdentityNumber).NotEmpty().WithMessage("please add ID");
            RuleFor(x => x.FirstName).NotNull().NotEmpty().Length(1, 50)
                                     .WithMessage("First name cannot be longer than 50 characters.");
            RuleFor(x => x.MiddleName).NotNull().NotEmpty().Length(1, 50);
            RuleFor(x => x.LastName).NotNull().NotEmpty().Length(1, 50);
            RuleFor(x => x.BirthDay).NotNull();
            RuleFor(x => x.PhoneNumber).NotEmpty().Length(1, 20);
            RuleFor(x => x.Province);
            RuleFor(x => x.City).Length(0, 200);
            RuleFor(x => x.District).NotEmpty().Length(1, 200);
            RuleFor(x => x.Address).NotEmpty().Length(1, 200);
            RuleFor(x => x.DepartmentId).NotEmpty();
        }
    }
}
