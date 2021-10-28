using System;

namespace SelectionStatementExercise
{
    class Program
    {
        public static void TryAgain()
         {
            Console.WriteLine("You guessed incorrectly. Do you want to try again?");
            var answer = Console.ReadLine();
            string yes = "yes";
            string y = "y";
            string no = "no";
            string n = "n";
            if (answer == yes.ToLower() || answer == y.ToLower())
            {
                GuessNumber();
            }

            if (answer == no.ToLower() || answer == n.ToLower())
            {
                Console.WriteLine("You have exited the game.");
            }

         }

        public static void GuessNumber()
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            Console.WriteLine("Guess my favorite number between 1 and 10");
            
            bool userInput = int.TryParse(Console.ReadLine(), out int num);
            
            if (num > 10 || num < 1 || !userInput)
            {
                Console.WriteLine("You chose a number out of range");
                TryAgain();
            }

            if (num < favNumber)
            {
                Console.WriteLine("Too low");
                //allow the user to  guess again if incorrect
                TryAgain();
            }

            else if (num > favNumber)
            {
                Console.WriteLine("Too high");                
                TryAgain();
            }
            else if (num == favNumber)
            {
                Console.WriteLine("Congratulations! You guess correctly!");
            }
            else
            {
                Console.WriteLine("You have exited the game the game.");
            }
        }
        static void Main(string[] args)
        {

            GuessNumber();
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch(subject.ToLower())

            {
                case "math":
                    Console.WriteLine("Math? WHAT! You crazy?!");
                    break;
                case "lunch":
                    Console.WriteLine("You picked the best subject: sandwiches");
                    break;
                case "recess":
                    Console.WriteLine("Recess! Tag, you're it!");
                    break;
                default:
                    Console.WriteLine("The subject you picked is boring");
                    break;
            }
        }
    }
}
