using Microsoft.AspNetCore.Mvc;

namespace mvc_cli.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }
    }
}
