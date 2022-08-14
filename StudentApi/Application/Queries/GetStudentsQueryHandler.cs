using MediatR;
using StudentApi.Models;

namespace StudentApi.Application.Queries
{
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, List<Student>>
    {
        private readonly FakeDataContext dataContext;
        public GetStudentsQueryHandler(FakeDataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<List<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            var list = await dataContext.GetAll();
            return list.ToList();
        }
    }
}