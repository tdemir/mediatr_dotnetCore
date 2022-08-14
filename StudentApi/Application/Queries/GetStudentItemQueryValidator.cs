using FluentValidation;

namespace StudentApi.Application.Queries;

public class GetStudentItemQueryValidator : AbstractValidator<GetStudentItemQuery>
{
    public GetStudentItemQueryValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
    }
}
