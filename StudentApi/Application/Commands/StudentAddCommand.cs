using MediatR;
using StudentApi.Models;

namespace StudentApi.Application.Commands;

public class StudentAddCommand : IRequest<Student>
{
    public string Name { get; set; } = string.Empty;
}
