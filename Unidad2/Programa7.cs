using System;

namespace Codigo6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, suma, resta, mul, div;
            double nada;
            string nombre;


            Console.WriteLine(" * * Bienvenido * * ");

            Console.Write("Escribe tu nombre:");
            nombre = Console.ReadLine();

            Console.Write("introduce tu primer numero:");
            n1 = Console.ReadLine();

            Console.Write("introduce tu segundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());


            suma = n1+n2;
            resta=n1-n2;
            multi=n1*n2; 
            div=n1 / n2;

        

            Console.WriteLine(nombre);
            Console.Write("Despues de hacer calculos bien makiabelicos");
            Console.Write($" El total de su Suma es  {suma}");
            Console.Write($" El total de su Resta es  {Resta}");
            Console.Write($" El total de su Multiplicacion es  {Multiplicacion}");
            Console.Write($" El total de su Division es  {Division}");
            console.WriteLine("--Gracias");

        }
    }
}