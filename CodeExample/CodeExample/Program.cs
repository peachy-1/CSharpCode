using System;

namespace RainFall
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] rain = new double[12];

            for (int i = 0; i < 12; i++)
            {
                try
                {
                    Console.WriteLine($"Please enter the amount of rain for month {i+1}");

                    rain[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);

                    i -= 1;
                }
            }

            RainFall rainfall = new RainFall(rain);

            Console.WriteLine($"Total rainfall:   {rainfall.TotalRain()}");
            Console.WriteLine($"Average rainfall: {rainfall.AvgRain()}");
            Console.WriteLine($"Highest rainfall: {rainfall.MostRain()}");
            Console.WriteLine($"Lowest rainfall:  {rainfall.LeastRain()}");
        }
    }
}
