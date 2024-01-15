using Microsoft.AspNetCore.Mvc;

namespace Meteoros.Assignment.Web.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
