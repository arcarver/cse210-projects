using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction defaultFraction = new Fraction();
        Fraction wholeFraction = new Fraction(5);
        Fraction twoParamFraction = new Fraction(6, 7);
        Console.WriteLine($"Top is {defaultFraction.GetTop()}");
        defaultFraction.SetTop(42);
        Console.WriteLine($"Top is now {defaultFraction.GetTop()}");
        Console.WriteLine($"Bottom is {defaultFraction.GetBottom()}");
        defaultFraction.SetBottom(63);
        Console.WriteLine($"Bottom is now {defaultFraction.GetBottom()}");
    }
}