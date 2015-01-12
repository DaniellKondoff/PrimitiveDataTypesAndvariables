using System;

    class NumValue
    {
        static void Main()
        {
            int? one = null;
            double? two = null;
            Console.WriteLine("Integer value is: {0}", one);
            Console.WriteLine("Double value is: {0}", two);

            one = 10;
            two = 10.5;
            Console.WriteLine("Integer value is: {0}", one);
            Console.WriteLine("Double value is: {0}", two);

            one = one.GetValueOrDefault() + 10;
            two = two.GetValueOrDefault() + 10.50;
            Console.WriteLine("Integer value is: {0}", one);
            Console.WriteLine("Double value is: {0}", two);

        }
    }

