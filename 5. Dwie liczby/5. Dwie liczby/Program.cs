using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwsza liczbe: ");
        int l1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj druga liczbe: ");
        int l2 = Convert.ToInt32(Console.ReadLine());

        if (l1 > l2)
        {
            Console.WriteLine("Większa liczbą jest: " + l1);
        }
        else
        {
            Console.WriteLine("Większą liczbą jest: " + l2);
        }
    }
}