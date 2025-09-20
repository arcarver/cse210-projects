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
        Console.WriteLine($"Fraction is {defaultFraction.GetFractionString()}");
        Console.WriteLine($"Decimal is {defaultFraction.GetDecimalValue()}");

        Fraction oneFraction = new Fraction(1);
        Fraction fiveFraction = new Fraction(5);
        Fraction threeFourthsFraction = new Fraction(3, 4);
        Fraction oneThirdFraction = new Fraction(1, 3);
        Console.WriteLine($"{oneFraction.GetFractionString()}");
        Console.WriteLine($"{oneFraction.GetDecimalValue()}");
        Console.WriteLine($"{fiveFraction.GetFractionString()}");
        Console.WriteLine($"{fiveFraction.GetDecimalValue()}");
        Console.WriteLine($"{threeFourthsFraction.GetFractionString()}");
        Console.WriteLine($"{threeFourthsFraction.GetDecimalValue()}");
        Console.WriteLine($"{oneThirdFraction.GetFractionString()}");
        Console.WriteLine($"{oneThirdFraction.GetDecimalValue()}");
    }
}