using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intruduzca un numero: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Intruduzca otro numero: ");
            double numberB = double.Parse(Console.ReadLine());

            if (numberA == numberB)
            {
                Console.WriteLine("Son iguales!");
                
            }
            else 
            {
                Console.WriteLine("No  son iguales :(");
                if (numberA < numberB)
                {
                    Console.WriteLine("El numero " + numberB + " es mayor que " + numberA);
                }
                else 
                {
                    Console.WriteLine("El numero " + numberA + " es mayor que " + numberB);
                }
            }
            
            
                
        }
    }
}
