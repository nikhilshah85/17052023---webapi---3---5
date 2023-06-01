using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI_demo_api_employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //this is not a good code, use DI instead
        //Employee empObj = new Employee(); 


        Employee _empObj;

        public EmployeeController(Employee _empObjREF)
        {
            _empObj = _empObjREF;
        }

        [Route("elist")]
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(_empObj.GetEmployees());
        }
    }
}
