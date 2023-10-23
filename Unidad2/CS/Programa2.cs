using System;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y, a;
            string nombre;


            Console.WriteLine(" * * Bienvenido * * ");

            Console.Write("Escribre tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("Escrine Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escrine a:");
            a = Convert.ToInt32(Console.ReadLine());



            x = y + a + 3;


            Console.WriteLine(nombre);
            Console.Write("Despues de la suma de y+a+3");
            Console.Write($" el resultado es {x}");
            Console.WriteLine("--Gracias");

        }
    }
}