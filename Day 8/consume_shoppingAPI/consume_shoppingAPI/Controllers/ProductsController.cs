using Microsoft.AspNetCore.Mvc;

namespace consume_shoppingAPI.Controllers
{
    public class ProductsController : Controller
    {


        public IActionResult ProductsList()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
