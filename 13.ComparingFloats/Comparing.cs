using System;

    class Comparing
    {
        static void Main()
        {
            Console.Write("Please enter number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter number b: ");
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equal = Math.Abs(a - b) < eps;
            Console.WriteLine("The result is: " +equal);
        }
    }

