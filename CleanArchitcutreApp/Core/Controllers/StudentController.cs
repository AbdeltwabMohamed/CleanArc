using Core.Features.Students.Queries.Models;
using Data.Entites;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator mediator;

        public StudentController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public IActionResult  GetStudent()
        {
             var result= mediator.Send(new GetStudentList());
            return Ok(result.Result);


        }
        
    }
}
