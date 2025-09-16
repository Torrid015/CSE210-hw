using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetFractionDecimals());
        Fractions fraction2 = new Fractions(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetFractionDecimals());
        Fractions fraction3 = new Fractions(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetFractionDecimals());
        Fractions fraction4 = new Fractions(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetFractionDecimals());
        
        
    }
}