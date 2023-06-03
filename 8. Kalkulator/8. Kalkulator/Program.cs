using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbe: ");
        double l1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbe: ");
        double l2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wybierz działanie jakie chcesz wykonać: ");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        int działanie = Convert.ToInt32(Console.ReadLine());


        if (działanie == 1)
        {
            Console.WriteLine("Wynik: " + (l1 + l2));
        }
        else if (działanie == 2)
        {
            Console.WriteLine("Wynik: " + (l1 - l2));
        }
        else if (działanie == 3)
        {
            Console.WriteLine("Wynik: " + (l1 * l2));
        }
        else if (działanie == 4)
        {
            if(l2 != 0)
            {
                Console.WriteLine("Wynik: " + (l1 / l2));
            }
            else
            {
                Console.WriteLine("Wynik: " + l1 + "/" + l2);
            }
        }
    }
}