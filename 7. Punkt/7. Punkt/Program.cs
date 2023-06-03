using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj x punktu P: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj y punktu P: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj promień: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double dystansdosrodka = Math.Sqrt(x * x + y * y);

        if (dystansdosrodka <= r)
        {
            Console.WriteLine("Punkt leży w obrębie koła");
        }
        else
        {
            Console.WriteLine("Punkt nie leży w obrębie koła");
        }
    }
}