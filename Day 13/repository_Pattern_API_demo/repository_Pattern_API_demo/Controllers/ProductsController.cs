using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository_Pattern_API_demo.Models;
namespace repository_Pattern_API_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        IProducts _productObj;

        public ProductsController(IProducts _iproductOBJREF)
        {
            _productObj = _iproductOBJREF;
        }

        [HttpGet]
        [Route("plist")]
        public IActionResult GetAllProducts()
        {
            var data = _productObj.GetProductsList();
            return Ok(data);
        }

    }
}
