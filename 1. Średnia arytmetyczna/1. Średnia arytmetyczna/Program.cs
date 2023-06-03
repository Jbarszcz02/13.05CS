using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("Wpisz trzy liczby:");

        Double l1 = Convert.ToDouble(Console.ReadLine());
        Double l2 = Convert.ToDouble(Console.ReadLine());
        Double l3 = Convert.ToDouble(Console.ReadLine());

        double sredniaaryt = (l1 + l2 + l3) / 3;
        Console.WriteLine("Średnia arytmetyczna wynosi: " + sredniaaryt);
    }
}