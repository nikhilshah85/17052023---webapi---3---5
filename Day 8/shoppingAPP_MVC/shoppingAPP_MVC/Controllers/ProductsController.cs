using Microsoft.AspNetCore.Mvc;

namespace shoppingAPP_MVC.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
