using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intruduzca su edad: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 65)
                Console.WriteLine("Oh, my dear Grandpa!");
            else if (age >= 18)
                Console.WriteLine("Now you can drink!");
            else 
                Console.WriteLine("You are so child!");
            
        }
    }
}
