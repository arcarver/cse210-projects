using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1, 101); 
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();


            guess = int.Parse(guessString);

            if (magicNumber < guess)
            {
                Console.WriteLine("lower");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

    }
}