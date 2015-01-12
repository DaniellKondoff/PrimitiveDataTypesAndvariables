using System;

    class Exchange
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Varieble a is: {0}\nVariable b is: {1}", a, b);
        }
    }

