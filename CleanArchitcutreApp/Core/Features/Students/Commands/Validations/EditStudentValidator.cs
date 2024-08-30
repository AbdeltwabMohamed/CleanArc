using Core.Features.Students.Commands.Models;
using FluentValidation;
using Service.Interfaces;

namespace Core.Features.Students.Commands.Validations
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {
        private readonly IStudentServices studentServices;

        public EditStudentValidator(IStudentServices studentServices)
        {

            Validate();
            Custom();
            this.studentServices = studentServices;
        }

        public void Validate()
        {
            RuleFor(e => e.Name).NotEmpty().WithMessage("Name Is Required")
                .NotNull().WithMessage("Name is required");
        }
        public void Custom()
        {

            RuleFor(e => e.Name).Must((Key, CancellationToken) => studentServices.isNameExist(Key.Name))
                .WithMessage("name is already exist");
        }
    }
}
