using System;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //algoritmo2
            int Cal1, Cal2, Cal3, Cal4, Cal5, Cal6, Promedio;
            string nombre;


            Console.WriteLine(" * * Bienvenido * * ");

            Console.Write("Escribre tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("Escrine tu Calificacion 1:");
            Cal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escrine tu Calificacion 2:");
            Cal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escrine tu Calificacion 3:");
            Cal3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escrine tu Calificacion 4:");
            Cal4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escrine tu Calificacion 5:");
            Cal5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escrine tu Calificacion 6:");
            Cal6 = Convert.ToInt32(Console.ReadLine());


            Promedio = (Cal1 + Cal2 + Cal3 + Cal4 + Cal5 + Cal6) / 6;


            Console.WriteLine(nombre);
            Console.Write("Despues de la suma de su Calificacion");
            Console.Write($" Tu Promedio es {Promedio}");
            Console.WriteLine("--Gracias");

        }
    }
}