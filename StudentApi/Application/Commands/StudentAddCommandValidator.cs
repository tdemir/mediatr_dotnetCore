using FluentValidation;

namespace StudentApi.Application.Commands
{
    public class StudentAddCommandValidator : AbstractValidator<StudentAddCommand>
    {
        public StudentAddCommandValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}