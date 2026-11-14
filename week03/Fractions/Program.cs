using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction outPut1 = new Fraction();
            Console.WriteLine(outPut1.GetFractionString());
            Console.WriteLine(outPut1.GetDecimalValue());

            Fraction outPut2 = new Fraction(5);
            Console.WriteLine(outPut2.GetFractionString());
            Console.WriteLine(outPut2.GetDecimalValue());

            Fraction outPut3 = new Fraction(3, 4);
            Console.WriteLine(outPut3.GetFractionString());
            Console.WriteLine(outPut3.GetDecimalValue());

            Fraction outPut4 = new Fraction(1, 3);
            Console.WriteLine(outPut4.GetFractionString());
            Console.WriteLine(outPut4.GetDecimalValue());
        }
    }
}