using System;

namespace Codigo8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Area, a, p;
            double nada;
            string nombre;


            Console.WriteLine(" * * Bienvenido * * ");

            Console.Write("Escribe tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("Introduce el valor de tu Apotema:");
            a = Console.ReadLine();

            Console.Write("introduce el valor de tu Perimetro:");
            p = Convert.ToInt32(Console.ReadLine());


            Area = (a*p)/2;
            
        

            Console.WriteLine(nombre);
            Console.Write("Despues de hacer calculos bien makiabelicos");
            Console.Write($" El Area de su Hexagono {Area}");
            console.WriteLine("--Gracias");

        }
    }
}