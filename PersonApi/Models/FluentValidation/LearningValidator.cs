using FluentValidation;
using PersonApi.ModelsDTO;

namespace PersonApi.Models.FluentValidation
{
    public class LearningValidator : AbstractValidator<CreateLearningDTO>
    {
        public LearningValidator()
        {
            RuleFor(x => x.UniversityName).Length(0, 200)
                                          .WithMessage("University Name cannot be longer than 200 characters.");
        }
    }
}
