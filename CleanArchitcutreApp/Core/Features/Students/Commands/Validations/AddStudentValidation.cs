using Core.Features.Students.Commands.Models;
using FluentValidation;

namespace Core.Features.Students.Commands.Validations
{
    public class AddStudentValidation : AbstractValidator<AddStudentCommand>
    {
        public AddStudentValidation()
        {


            Validate();
        }

        public void Validate()
        {
            RuleFor(e => e.Name).NotEmpty().WithMessage("Name is required")
                .NotNull().WithMessage("Name is required");
        }
    }
}
