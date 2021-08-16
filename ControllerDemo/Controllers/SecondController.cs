using ControllerDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerDemo.Controllers
{
    public class SecondController : Controller
    {
        // GET
        public IActionResult Index(int id)
        {
            return View(new SecondViewModel { Id = id} );
        }
    }
}