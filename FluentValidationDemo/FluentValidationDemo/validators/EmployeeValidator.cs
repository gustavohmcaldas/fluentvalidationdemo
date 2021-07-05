using FluentValidation;
using FluentValidationDemo.entities;
using System;
using System.Linq;

namespace FluentValidationDemo.validators
{
    class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Length(2, 30).WithMessage("{PropertyName} must be between 2 to 30 characters.")
                .Must(BeAValidName).WithMessage("{PropertyName} contains invalid characters.");

            RuleFor(x => x.LastName).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Length(2, 30).WithMessage("{PropertyName} must be between 2 to 30 characters.")
                .Must(BeAValidName).WithMessage("{PropertyName} contains invalid characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .EmailAddress().WithMessage("{PropertyName} contains invalid characters.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Matches("^[1-9]\\d{2}-\\d{3}-\\d{4}").WithMessage("{PropertyName} must follow 999-999-9999 format.");

            RuleFor(x => x.HiredDate)
                .Must(BeAValidHiredDate).WithMessage("{PropertyName} cannot be a future date.");

            RuleFor(x => x.Job).SetValidator(new JobValidator());
            RuleFor(x => x.Location).SetValidator(new LocationValidator());

            RuleFor(x => x.Location.City)
                .NotEmpty().When(x => x.Job.Title.Equals("Project Manager"))
                .WithMessage("City cannot be empty if Job Title is Project Manager.");

            RuleFor(x => x.Location.Province)
                .Equal("British Columbia")
                .When(x => x.Job.Title.Equals("Software Engineer"))
                .WithMessage("{PropertyName} must be British Columbia if Job Title is Software Engineer.");
        }

        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }

        protected bool BeAValidHiredDate(DateTime date)
        {
            if(date > DateTime.Now)
            {
                return false;
            }
            return true;
        }
    }

    /*
    Employee Rules:
    FirstName => nao pode ser vazio, tem que ter entre 2 a 30 caracteres, sem numeros
    LastName => nao pode ser vazio, tem que ter entre 2 a 30 caracteres, sem numeros
    Email => nao pode ser vazio, email valido
    Phone Number => 236-878-4211 (formato)[usar regex]
    Hired Date => Nao pode ser data futura
    */
}
