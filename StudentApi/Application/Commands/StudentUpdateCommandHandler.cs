using MediatR;
using StudentApi.Models;

namespace StudentApi.Application.Commands
{
    public class StudentUpdateCommandHandler : IRequestHandler<StudentUpdateCommand>
    {
        private readonly FakeDataContext dataContext;
        public StudentUpdateCommandHandler(FakeDataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<Unit> Handle(StudentUpdateCommand request, CancellationToken cancellationToken)
        {
            var student = await dataContext.GetById(request.Id);
            if (student != null)
            {
                student.Name = request.Name;
                await dataContext.Update(student);
            }

            return Unit.Value;
        }
    }
}