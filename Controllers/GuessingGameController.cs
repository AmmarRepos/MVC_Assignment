using Microsoft.AspNetCore.Mvc;

namespace mvc_cli.Controllers
{
   public class GuessingGameController : Controller
    {
	public bool IsCorrect { get; set; } = false;
        public string CheckGuess(int guess, int? secretNumber)
        {
            if(guess == secretNumber)
            {
                IsCorrect = true;
                return "Congratulations. Try Again";
            }

            else if ( guess > 100)
            {
                return "Guess a num btw 1,100";
            }

            else if (guess > secretNumber)
            {
                return "Guess a smaller num";
            }

            else if (guess < secretNumber)
            {
                return "Guess a larger num";
            }
            return "Invalid input";
        }
    
        Random random = new Random();

        public IActionResult GuessingGame()
        {
	    if (HttpContext.Session.GetInt32("number") == null)
            {
                HttpContext.Session.SetInt32("number", random.Next(1, 100));
	    }
            return View();
        }

	[HttpPost]
        public IActionResult GuessingGame(int guessNumber)
        {
            ViewBag.Msg = CheckGuess(guessNumber, HttpContext.Session.GetInt32("number"));
            if (IsCorrect)
            {
                HttpContext.Session.SetInt32("number", random.Next(1, 100));
            }
            return View();
        }
    }
}
