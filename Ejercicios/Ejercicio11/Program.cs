using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Cita");
            Console.WriteLine("2.Chiste");
            Console.WriteLine("3.Insulto");
            Console.Write("Intruduzca un numero del 1 al 3: ");
            int numberA = int.Parse(Console.ReadLine());
            switch(numberA)

            {
                case 1:
                    Console.WriteLine("Hakuna Matata, vive y deja vivir");
                    break;
                case 2:
                    Console.WriteLine("Final Fantasy 7 Remake va a ser un gran juego!");
                    break;
                case 3:
                    Console.WriteLine("El mono sabe leer");
                    break;
                default:
                    Console.WriteLine("Vuelve a intruducir un numero");
                    break;
                
            }
        }
    }
}
