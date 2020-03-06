using System;

namespace Task1
{
    class Program
    {
        static int factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input D if degrees, input R if radians");
            string choice = Console.ReadLine();

            if (choice == "D")
                x = x * Math.PI / 180;//to radians if degrees chosen

            x = x % Math.PI;
            x = x > Math.PI/2 ? x - Math.PI : x;
            x = x < -Math.PI / 2 ? x + Math.PI : x; //converting to interval between -pi/2 and pi/2


            double result = 0;
            for(int n=0;n<11;n++)
            {
                double iteration = Math.Pow(-1, n) / factorial(2 * n + 1);
                iteration *= Math.Pow(x, 2 * n + 1);
                result += iteration;
                Console.WriteLine("Iteration: {0}", n);
                Console.WriteLine("Result: {0}", result);
            }
            Console.WriteLine();
            Console.WriteLine("Computer's Result: {0}", Math.Sin(x));
            Console.WriteLine();
            Console.WriteLine("Compare: {0}", Math.Abs(result - Math.Sin(x)));

            Console.ReadKey();
        }
    }
}
