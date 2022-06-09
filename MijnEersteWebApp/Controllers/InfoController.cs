using Microsoft.AspNetCore.Mvc;
using MijnEersteWebApp.Models;

namespace MijnEersteWebApp.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult About()
        {
            //return View(new InfoViewModel { Age = 26, FirstName = "Ken", LastName = "Field" });
            var vm = new InfoViewModel { Age = 16, FirstName = "Ken", LastName = "Field" };
            return View(vm);
        }
    }
}
