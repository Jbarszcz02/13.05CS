using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadz pierwszy bok trójkąta:");
        double b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Wprowadz drugi bok trójkąta:");
        double b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Wprowadz trzeci bok trójkąta:");
        double b3 = double.Parse(Console.ReadLine());

        if ( b1 == b2 && b2 == b3)
        {
            Console.WriteLine("Boki stworzą trójkąt rownoboczny");
        }
        else
        {
            Console.WriteLine("Boki nie stworza trójkąta równobocznego");
        }
    }
}