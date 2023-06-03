using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadz wage: ");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadz wzrost w metrach");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double BMI = waga / (wzrost * wzrost);
        BMI = Math.Round(BMI, 2);
        Console.WriteLine("Twoje BMI wynosi: " + BMI);
    }
}