using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su altura: ");
            int x = int.Parse(Console.ReadLine());

            if (x <= 135)
            {
                Console.WriteLine("Mi petanquillo mareeee!!!");
            }
            else if (x >= 136 && x < 177)
            {
                Console.WriteLine("Tas bien");
            }
            else if (x >= 177 && x < 187)
            {
                Console.WriteLine("Ta mu bien!");
            }
                
            else
                Console.WriteLine("Mah largo que un dia sin pan!!!");
        }
    }
}
