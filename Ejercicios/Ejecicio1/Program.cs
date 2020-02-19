using System;

namespace Ejecicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intruduzca un numero: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Intruduzca otro numero: ");
            double numberB = double.Parse(Console.ReadLine());

            Console.WriteLine("La suma es " + (numberA + numberB));
            Console.WriteLine("La multiplicación es " + (numberA * numberB));
            Console.WriteLine("La división es " + (numberA / numberB));
            Console.WriteLine("La resta es " + (numberA - numberB));
            Console.WriteLine("El resto de " + numberA + " y " + numberB + " es " + (numberA % numberB));






        }
    }
}
