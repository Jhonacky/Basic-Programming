using System;

namespace ejercicioPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            
            Console.WriteLine("Enter your age");
            edad = int.Parse(Console.ReadLine());

            if(edad >= 18){
                Console.WriteLine("You're older than 18");
            }
            else{Console.WriteLine("You're younger than 18");
            }
        }
    }
}
