using System;

class Program
{
    static void Main(string[] args)
    {
        fraction one = new fraction();
        Console.WriteLine(one.getFractionString());
        Console.WriteLine(one.getDecimalValue());

        fraction one1 = new fraction(5);
        Console.WriteLine(one1.getFractionString());
        Console.WriteLine(one1.getDecimalValue());

        fraction one2 = new fraction(3, 4);
        Console.WriteLine(one2.getFractionString());
        Console.WriteLine(one2.getDecimalValue());
    }
}