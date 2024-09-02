using Core.Features.Departments.Query.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitcutreAppAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DepartmentController : AppControllerBase
    {


        [HttpGet]
        public ActionResult GetAll()
        {
            var res = Mediator.Send(new GetDepartmentsList());
            return NewResult(res.Result);

        }
    }
}
