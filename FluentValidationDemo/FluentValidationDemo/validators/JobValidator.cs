using FluentValidation;
using FluentValidationDemo.entities;

namespace FluentValidationDemo.validators
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please select a 'Job Title'.");

            RuleFor(x => x.Salary).NotEmpty().WithMessage("'Salary' cannot be empty.");

            RuleFor(x => x.Salary)
                .InclusiveBetween(8000, 10000)
                    .When(x => x.Title.Equals("Project Manager"))
                    .WithMessage("Project Manager Salary must be between 8000 and 10000");

            RuleFor(x => x.Salary)
                .InclusiveBetween(4000, 8000)
                    .When(x => x.Title.Equals("Software Engineer"))
                    .WithMessage("Software Engineer Salary must be between 4000 and 8000");

            RuleFor(x => x.Salary)
                .InclusiveBetween(1500, 2000)
                    .When(x => x.Title.Equals("Intern"))
                    .WithMessage("Intern Salary must be between 1500 and 2000");
        }

        /*Title => cannot be empty
        Salary => cannot be empty

        *Custom rules:
        Project Manager => salary between 8000 and 10000 and City cannot be empty
        Software Engineer => salary between 4000 and 8000 and Province must be British Columbia
        Intern => salary between 1500 to 2000
        */
    }
}
