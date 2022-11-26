using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float speed, km, time;

            Console.WriteLine("Enter the distance in km");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed");
            speed = float.Parse(Console.ReadLine());

            time = km / speed;

            Console.WriteLine("The aproximated time is: " + time.ToString("0.0") + "hours...");

        }
    }
}
