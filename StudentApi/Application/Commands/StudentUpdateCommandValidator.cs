using FluentValidation;

namespace StudentApi.Application.Commands
{
    public class StudentUpdateCommandValidator : AbstractValidator<StudentUpdateCommand>
    {
        public StudentUpdateCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}