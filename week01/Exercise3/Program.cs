using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        string magicNumberString = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberString);
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