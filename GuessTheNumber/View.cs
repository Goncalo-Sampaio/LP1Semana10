using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View : IView
    {
        public void GameStart(){
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public int Guess(){
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void WinMessage(int attempts){
            Console.WriteLine(
                "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void LowNumber(){
            Console.WriteLine("Too low! Try again.");
        }

        public void HighNumber(){
            Console.WriteLine("Too high! Try again.");
        }

        public void EndGame(){
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}