using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, result;

            Console.WriteLine("Enter a number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            n2 = int.Parse(Console.ReadLine());

            result = n1 + n2;

            Console.WriteLine("The result between the sum of n1 and n2 is: " + result);

        }
    }
}
