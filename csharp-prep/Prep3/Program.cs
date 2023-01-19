using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101);

        int guess = -10;
        int count = 0;

        while(guess != mNumber) {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (mNumber < guess) {
                Console.WriteLine("lower");
                count++;
            }
            else if (mNumber > guess) {
                Console.WriteLine("higher");
                count++;
            }
            else {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {count} guesses to win!");
            }
        }
    }
}