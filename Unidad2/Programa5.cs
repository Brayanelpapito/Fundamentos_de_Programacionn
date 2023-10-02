using System;

namespace Codigo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int metros;
            double pies;
            string nombre;


            Console.WriteLine(" * * Bienvenido * * ");

            Console.Write("Escribre tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("Escribre tus metros:");
            metros= Convert.ToInt32(Console.ReadLine());

            pies = metros * 3.281;



            Console.WriteLine(nombre);
            Console.Write("Despues de hacer calculos bien makiabelicos");
            Console.Write($" sus metros son  {pies} pies");
            console.WriteLine("--Gracias");

        }
    }
}