using MediatR;
using StudentApi.Models;

namespace StudentApi.Application.Queries
{
    public class GetStudentItemQuery : IRequest<Student>
    {
        public int Id { get; set; }
    }
}