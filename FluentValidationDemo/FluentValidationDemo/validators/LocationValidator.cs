using FluentValidation;
using FluentValidationDemo.entities;

namespace FluentValidationDemo.validators
{
    public class LocationValidator : AbstractValidator<Location>
    {
        public LocationValidator()
        {
            RuleFor(x => x.Province).NotEmpty().WithMessage("Please select a Province.");

            //RuleFor(x => x.City).Length(5, 50).DependentRules(() =>
            //{
            //    RuleFor(x => x.City).NotEmpty();
            //}).WithMessage("City must be empty or between 5 to 50 characters.");

            RuleFor(x => x.City).Length(5, 50)
                .When(x => !x.City.Equals(""))
                .WithMessage("City must be empty or between 5 to 50 characters.");

            RuleFor(x => x.City).NotEmpty()
                .When(x => !x.Street.Equals(""))
                .WithMessage("'City' is required if 'Street' is filled out.");

            //RuleFor(x => x.City).NotEmpty().DependentRules(() =>
            //{
            //    RuleFor(x => x.Street).NotEmpty();
            //}).WithMessage("'City' is required if 'Street' is filled out.");

            RuleFor(x => x.Street).Length(20, 200)
                .When(x => !x.Street.Equals(""))
                .WithMessage("Street must be empty or between 20 to 200 characters.");

            //RuleFor(x => x.Street).Length(20, 200).DependentRules(() =>
            //{
            //    RuleFor(x => x.Street).NotEmpty();
            //}).WithMessage("Street must be empty or between 20 to 200 characters.");
        }
    }
}
