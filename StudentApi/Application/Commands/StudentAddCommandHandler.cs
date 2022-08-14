using MediatR;
using StudentApi.Models;

namespace StudentApi.Application.Commands;

public class StudentAddCommandHandler : IRequestHandler<StudentAddCommand, Student>
{
    private readonly FakeDataContext dataContext;
    public StudentAddCommandHandler(FakeDataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    // public async Task<Unit> Handle(StudentAddCommand request, CancellationToken cancellationToken)
    // {
    //     var newStudent =
    //     await this.dataContext.Add(request.Student);

    //     return Unit.Value;
    // }

    public async Task<Student> Handle(StudentAddCommand request, CancellationToken cancellationToken)
    {
        var allStudents = await this.dataContext.GetAll();

        var newStudent = new Student();
        newStudent.Name = request.Name;
        if (allStudents.Any())
        {
            newStudent.Id = allStudents.Max(x => x.Id) + 1;
        }
        await this.dataContext.Add(newStudent);

        return newStudent;
    }
}
