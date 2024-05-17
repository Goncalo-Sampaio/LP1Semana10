using System;

namespace GuessTheNumber
{
    public class Controller
    {
        public void Start(IView view)
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            int targetNumber = random.Next(1, 101);

            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            view.GameStart();

            // Game loop
            while (!guessedCorrectly)
            {
                guess = view.Guess();
                attempts++;

                if (guess == targetNumber)
                {
                    view.WinMessage(attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    view.LowNumber();
                }
                else
                {
                    view.HighNumber();
                }
            }
            view.EndGame();
        }
    }
}