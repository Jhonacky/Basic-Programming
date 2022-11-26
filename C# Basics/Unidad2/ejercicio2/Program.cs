using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, result;

            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            result = n * n * n;
            Console.WriteLine("This is the result of " + result + " to the third");
        }
    }
}
