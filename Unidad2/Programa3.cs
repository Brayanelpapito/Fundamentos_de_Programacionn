using System;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int area, a, b, p;
            string nombre;


            Console.WriteLine(" * * Bienvenido * * ");

            Console.Write("Escribre tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("Escrine la altura de tu triangulo:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escrine la Base de tu triangulo:");
            b = Convert.ToInt32(Console.ReadLine());



            area = (b * a) / 2;
            p = b + a + a;


            Console.WriteLine(nombre);
            Console.Write("Despues de hacer calculos bien makiabelicos");
            Console.Write($" El area de su triangulo es {area}");
            Console.Write($" y ");
            Console.Write($"El perimetro de su triangulo es {p}");
            Console.WriteLine("--Gracias");

        }
    }
}