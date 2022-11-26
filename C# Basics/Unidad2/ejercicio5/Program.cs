using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, promedy;

            Console.WriteLine("Enter the first note");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second note");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third note");
            n3 = float.Parse(Console.ReadLine());

            promedy = (n1 + n2 + n3) / 3;

            Console.WriteLine("The student's promedy is: " + promedy.ToString("0.0"));


        }
    }
}
