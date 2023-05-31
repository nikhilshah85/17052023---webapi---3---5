using Microsoft.AspNetCore.Mvc;
using httpclient_api_calls.Models;
namespace httpclient_api_calls.Controllers
{
    public class ExternalDataController : Controller
    {

        Postdata postObj = new Postdata();


        public IActionResult PostData()
        {
            ViewBag.data = postObj.GetPostDataFromAPI();
            return View();
        }
    }
}
