using MediatR;
using StudentApi.Models;

namespace StudentApi.Application.Queries;

public class GetStudentsQuery : IRequest<List<Student>>
{
}
