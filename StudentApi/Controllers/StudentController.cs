using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Application.Commands;
using StudentApi.Application.Queries;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IMediator mediator, ILogger<StudentController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok(DateTime.Now.ToLongTimeString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var request = new GetStudentsQuery();
            var list = await _mediator.Send(request);
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var request = new GetStudentItemQuery();
            request.Id = id;
            var list = await _mediator.Send(request);
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> Add(StudentAddCommand request)
        {
            var resp = await _mediator.Send(request);
            return Ok(resp);
        }

        [HttpPut]
        public async Task<IActionResult> Add(StudentUpdateCommand request)
        {
            await _mediator.Send(request);
            return Ok(true);
        }
    }
}