using Microsoft.AspNetCore.Mvc;
using mvc_cli.Models;
namespace mvc_cli.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Fevercheck()
	{
            return View();
	}
        [HttpPost]
        public IActionResult Fevercheck(string temperature)
        {
	    /* string feverMsg;
	    feverMsg = (int.Parse(temperature) >= 37) ? "Sick" : "Normal";
	    ViewBag.Msg = feverMsg;*/
	    ViewBag.Msg = DoctorModel.checkFever(temperature);
            return View();
        }
    }
}
