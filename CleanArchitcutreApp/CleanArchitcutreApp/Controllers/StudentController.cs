using Core.Features.Students.Commands.Models;
using Core.Features.Students.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitcutreAppAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StudentController : AppControllerBase
    {

        [HttpGet]
        [Route("55")]
        public IActionResult GetStudent()
        {
            var result = Mediator.Send(new GetStudentList());
            return NewResult(result.Result);


        }

        [HttpGet]
        [Route("student/{Id}")]
        public IActionResult getbyid(int Id)
        {


            var res = Mediator.Send(new GetStudentById() { Id = Id });
            return NewResult(res.Result);


        }
        [HttpPost]
        public IActionResult Add(AddStudentCommand st)
        {

            var res = Mediator.Send(st);
            return NewResult(res.Result);
        }
        [HttpPut]
        public IActionResult update(EditStudentCommand st)
        {

            var res = Mediator.Send(st);
            return NewResult(res.Result);
        }
    }
}
