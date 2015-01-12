using System;

    class StringAndObjects
    {
        static void Main()
        {
            string hello = "\"Hello";
            string word = "World\"";
            object c = hello + " " + word;
            string result = (string)c;
            Console.WriteLine(result);
        }
    }

