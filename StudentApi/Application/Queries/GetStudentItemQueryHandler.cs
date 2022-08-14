using MediatR;
using StudentApi.Models;

namespace StudentApi.Application.Queries
{
    public class GetStudentItemQueryHandler : IRequestHandler<GetStudentItemQuery, Student>
    {
        private readonly FakeDataContext dataContext;
        public GetStudentItemQueryHandler(FakeDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Student> Handle(GetStudentItemQuery request, CancellationToken cancellationToken)
        {
            var item = await dataContext.GetById(request.Id);

            return item;
        }
    }
}