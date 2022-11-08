using Microsoft.AspNetCore.Mvc;
using mvc_cli.Models;
namespace mvc_cli.Controllers
{
   public class GuessingGameController : Controller
    {
	
        public IActionResult GuessingGame()
        {
	    if (HttpContext.Session.GetInt32("number") == null)
            {
                HttpContext.Session.SetInt32("number", GuessingGameModel.random.Next(1, 100));
	    }
            return View();
        }

	[HttpPost]
        public IActionResult GuessingGame(int guessNumber)
        {
            ViewBag.Msg = GuessingGameModel.CheckGuess(guessNumber, HttpContext.Session.GetInt32("number"));
            if (GuessingGameModel.IsCorrect)
            {
                HttpContext.Session.SetInt32("number", GuessingGameModel.random.Next(1, 100));
            }
            return View();
        }
    }
}
