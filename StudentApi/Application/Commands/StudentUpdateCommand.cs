using MediatR;

namespace StudentApi.Application.Commands
{
    public class StudentUpdateCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}