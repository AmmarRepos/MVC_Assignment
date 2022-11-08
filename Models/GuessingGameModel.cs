namespace mvc_cli.Models;

public class GuessingGameModel
{
    	public static bool IsCorrect { get; set; } = false;
        public static string CheckGuess(int guess, int? secretNumber)
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
     public static Random random = new Random();
}
