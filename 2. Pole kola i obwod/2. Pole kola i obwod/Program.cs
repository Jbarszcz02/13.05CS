using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pole koła:");

        double Pole= Convert.ToDouble(Console.ReadLine());

        double promien = Math.Sqrt(Pole / Math.PI);

        double obwod = 2 * Math.PI * promien;

        Console.WriteLine("Obwód koła wynosi: " + obwod);
    }
}