using System;

namespace Task1
{
    class Program
    {
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

            int numOfFact = 1;
            int fact = 1;
            double xInPower = x;
            double result = 0;
            for(int n=0;n<11;n++)
            {
                double iteration = Math.Pow(-1, n) / fact;
                iteration *= xInPower;
                result += iteration;
                Console.WriteLine("Iteration: {0}\nResult: {1}", n, result);
                fact *= (numOfFact + 1) * (numOfFact + 2);
                numOfFact += 2;
                xInPower *= x * x;
            }
            Console.WriteLine("\nComputer's Result: {0}", Math.Sin(x));
            Console.WriteLine("\nComparison with Program's result: {0}", Math.Abs(result - Math.Sin(x)));

            Console.ReadKey();
        }
    }
}
