using Microsoft.AspNetCore.Mvc;

namespace Meteoros.Assignment.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
