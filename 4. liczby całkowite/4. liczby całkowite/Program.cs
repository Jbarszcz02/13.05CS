using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadż pierwszy licznik a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadż pierwszy mianownik b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadź drugi licznik c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadż drugi mianownik d: ");
        int d = Convert.ToInt32(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            Console.WriteLine("Licznik wynosi: " + (a * d + b * c));
            Console.WriteLine("Mianownik wynosi: " + b * d);
        }
    }
}