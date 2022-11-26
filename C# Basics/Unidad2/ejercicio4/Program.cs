using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float salary, billed;

            salary = 15000F;
            Console.WriteLine("Enter the billed amount of the month:");
            billed = float.Parse(Console.ReadLine());
            salary += billed * 0.05F;

            Console.WriteLine("The salary this month of the employee is " + salary);


        }
    }
}
