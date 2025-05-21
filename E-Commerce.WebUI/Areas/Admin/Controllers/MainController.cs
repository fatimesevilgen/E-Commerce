using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]  //Main controlller area da Admin bölgesi için çalışcak
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
