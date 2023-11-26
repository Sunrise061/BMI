using System;

namespace BMI_niedziela
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg, height, bmi;

            Console.WriteLine("Podaj swoją wagę(W kg) ");
            kg = Double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj swój wzrost(W metrach) ");
            height = Double.Parse(Console.ReadLine());

            bmi = (kg / (height * height));
            Console.WriteLine(Math.Round(bmi, 2));
            Console.ReadKey();

        }
    }
}
