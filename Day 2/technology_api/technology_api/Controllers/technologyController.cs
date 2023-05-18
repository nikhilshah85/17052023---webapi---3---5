using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace technology_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class technologyController : ControllerBase
    {
        static List<string> techList = new List<string>()
        {
            ".Net","SQL Server","Angular","Azure"
        };

        [HttpGet]
        [Route("techlist")]
        public IActionResult GetAllTechnologies()
        {
            return Ok(techList);
        }

        [HttpGet]
        [Route("techlist/filter/{idx}")]
        public IActionResult GetTechnologyByIndex(int idx)
        {
            string tech = techList[idx];
            return Ok(tech);
        }
        [HttpGet]
        [Route("techlist/sort/{sortOrder}")]
        public IActionResult GetTechnogyByOrder(string sortOrder)
        {
            if (sortOrder.Equals("ascending"))
            {
                var result = (from a in techList
                             orderby techList ascending
                             select a).ToList();

                return Ok(result);
            }
            else
            {
                var result = (from a in techList
                             orderby techList descending
                             select a).ToList();
                return Ok(result);
            }

        }



        [HttpPost]
        [Route("techlist/add/{newTechName}")]
        public IActionResult AddNewTech(string newTechName)
        {
            techList.Add(newTechName);
            return Created("", "Technology Added Successfully");
        }

        [HttpDelete]
        [Route("techlist/delete/{idx}")]
        public IActionResult DeleteTech(int idx)
        {
            techList.RemoveAt(idx);
            return Accepted("Technology Removed Successfully");
        }

        [HttpPut]
        [Route("techlist/edit/{idx}/{newName}")]
        public IActionResult UpdateTech(int idx, string newName)
        {
            techList[idx] = newName;
            return Accepted("Technology Name updated succssfully");
        }




    }
}
