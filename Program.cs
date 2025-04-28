// This game involves a secret number being chosen by the computer within a specific range (let’s say 1-100) and the player then tries to guess this number.

// If the number they guess is too low, the program will say “too low” and if it is too high it will reply with “too high”.
// The player wins when they guess the correct number.

// Added Difficulty: Put a limit on how many wrong guesses they can have. Too many and the game ends with “You lose”.

// rocket Tips: First thing to look at is generating a random number. Despite the language you choose,
// most of the time a random number can be created using a random generator function or object.
// .NET has the “Random” object and C++ has rand().
// Once you have a random number chosen, ask the player for a guess.
// Compare their guess to this random number chosen. An easy if statement can be used to see if it is too high or too low.
// If they are equal, tell the player they win and restart the game.

namespace _01_High_Low_Number_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PlayGame();
                Console.WriteLine("Do you want to play again? (yes/no)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "no")
                {
                    break;
                }
                if (answer == "yes")
                {
                    continue;
                }
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }
        static void PlayGame()
        {
            Console.WriteLine("Welcome to the random number guesser!");
            Console.WriteLine();
            Console.WriteLine("I will generate a number between 0 and 100, try to guess my number.");
            Console.WriteLine("You only get 10 tries to guess the number.");
            Console.WriteLine("I will let you know if your guess is too high or too low.");
            Console.WriteLine();

            int randomNumber = new Random().Next(0, 100);
            int guess = 0;
            int tries = 0;
            int maxTries = 10;
            while (tries < maxTries)
            {
                tries++;
                Console.WriteLine();
                Console.WriteLine($"Guess number {tries}.");
                Console.Write("Please enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                if (guess == randomNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {randomNumber} in {tries} tries.");
                    break;
                }
                if (tries == maxTries)
                {
                    Console.WriteLine($"Sorry, you've used all your tries. The number was {randomNumber}.");
                }
                if (Math.Abs(guess - randomNumber) < 5)
                {
                    Console.WriteLine("You're close!");
                }

                Console.WriteLine($"You have { maxTries - tries } tries left.");
            }
        }
    }
}
