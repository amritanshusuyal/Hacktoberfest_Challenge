using System;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int b; int num; int j;
            string divisors = "";

            Console.Write("The last number of a range to verify is they are Perfect Numbers: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                b = 0;

                for (j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        b += j;
                        divisors += " " + j + " ";
                    }
                }
                if (b == i)
                    Console.WriteLine("The Number " + i + " is perfect and his divisors are: " + divisors);

                divisors = "";
            }

            Console.ReadKey();
        }
    }
}
