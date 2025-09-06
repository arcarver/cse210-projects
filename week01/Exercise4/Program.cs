using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        List<int> numbers;
        numbers = new List<int>();
        int number = 45;
        do
        {
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");
        float totalItems = numbers.Count;
        float average = total / totalItems;
        Console.WriteLine($"The average is: {average}");




        // foreach (int item in numbers)
        // {
        //     Console.WriteLine(item);
        // }

    }
}