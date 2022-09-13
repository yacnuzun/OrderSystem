using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
