using System;

namespace Codigo6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int p1, p2, p3, iva, st, total;
            double nada;
            string nombre;


            Console.WriteLine(" * * Bienvenido * * ");

            Console.Write("Escribre tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("Escribre el precio de tu Producto 1:");
            p1 = Console.ReadLine();

            Console.Write("Escribre el precio de tu Producto 2:");
            p2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribre el precio de tu Product 3:");
            p3 = Convert.ToInt32(Console.ReadLine());

            st = p1+p2+p3;
            iva=st*.16;
            total=iva+st;

        

            Console.WriteLine(nombre);
            Console.Write("Despues de hacer calculos bien makiabelicos");
            Console.Write($" su subtotal es  {st}");
            Console.Write($" su precio con iva es  {iva}");
            Console.Write($" su total es {total}");
            console.WriteLine("--Gracias");

        }
    }
}