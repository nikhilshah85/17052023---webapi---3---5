using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using employeeAPI.Models;
namespace employeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        employeeDetails eObj = new employeeDetails(); //this is a bad code, old practice we should use Dependency Injection instead

        [HttpGet]
        [Route("emp/list")]
        public IActionResult GetAllEmployees()
        {
            var emp = eObj.GetAllEmployees();
            return Ok(emp);
        }

        [HttpGet]
        [Route("emp/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var emp = eObj.GetEmpById(id);
            return Ok(emp);
        }


        [HttpGet]
        [Route("emp/count")]
        public IActionResult GetTotalEmployees()
        {
            var total = eObj.TotalEmployees();
            return Ok(total);
        }

        [HttpPost]
        [Route("emp/add")]
        public IActionResult AddEmployee(employeeDetails empDetails)
        {
          var result =   eObj.AddnewEmployee(empDetails);
            return Created("", result);
        }
        [HttpDelete]
        [Route("emp/delete/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
           var result =  eObj.DeleteEmployee(id);
            return Accepted(result);
        }
        [HttpPut]
        [Route("emp/edit")]
        public IActionResult EditEmployee(employeeDetails editInfo)
        {
            var result = eObj.EditEmployee(editInfo);
            return Ok(result);
        }
    }
}
