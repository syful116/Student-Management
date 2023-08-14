using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Core.Student.Command;
using StudentManagement.Core.Teacher.Command;
using StudentManagement.Core.Teacher.Query;
using StudentManagement.Model;
using StudentManagement.Services.Model;

namespace StudentManagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TeacherController : ControllerBase
{
    private readonly IMediator _mediator;
    public TeacherController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]

    public async Task<ActionResult<VmTeacher>> GetAll()
    {
        var data=await _mediator.Send(new GetAllTeacherQuery());
        return Ok(data);
    }

    [HttpGet("id")]
    public async Task<ActionResult<VmTeacher>> GetById(int id)
    {
        var data = await _mediator.Send(new GetTeacherById(id));
        return Ok(data);
    }

    [HttpPost]
    public async Task<ActionResult<VmTeacher>> Create([FromBody] VmTeacher teacher)
    {
        var data = await _mediator.Send(new CreateTecher(teacher));
        return Ok(data);
    }

    [HttpPut("id")]

    public async Task<ActionResult<VmTeacher>> Update(int id, [FromBody] VmTeacher Teacher)
    {
        var data = await _mediator.Send(new UpdateTeacher(id, Teacher));
        return Ok(data);

    }


    [HttpDelete("id")]

    public async Task<ActionResult<VmTeacher>> Delete(int id)
    {
        var data = await _mediator.Send(new DeleteTeacher(id));
        return Ok(data);

    }

}
