using System;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int GC;
            double GF;
            string nombre;


            Console.WriteLine(" * * Bienvenido * * ");

            Console.Write("Escribre tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("Escribre tus grados centigrados:");
            GC = Convert.ToInt32(Console.ReadLine());

            GF = GC * 1.8 + 32;



            Console.WriteLine(nombre);
            Console.Write("Despues de hacer calculos bien makiabelicos");
            Console.Write($" sus grados centigrados son  {GF} grados farenheit");
            Console.WriteLine("--Gracias");

        }
    }
}