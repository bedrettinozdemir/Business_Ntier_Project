using Microsoft.AspNetCore.Mvc;

namespace Business_Ntier_Project.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
