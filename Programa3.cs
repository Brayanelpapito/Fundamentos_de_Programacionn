using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0, er, F,  k;
            int tan;
            Console.Write("Escribe el total de Temperaturas a procesar:");
            tan = Convert.ToInt32(Console.ReadLine());
            double[] cuantos = new double[tan];
            Console.WriteLine("                  ");
            Console.WriteLine("Hola");

            for (double c = 0; c < cuantos.Length; c++)
               
            {
                Console.Write("Escribe tu Temperatura;");
                er = Convert.ToInt32(Console.ReadLine());



                F = (er*1.8) + 32;
                k = ((F - 32) / 1.8 ) + 273.15;

                Console.WriteLine("Tus Grados Centigrados son:" + er);
                Console.WriteLine("Tus Grados Farenheit son:" + F);
                Console.WriteLine("Tus Grados Kelvin son:" + k);
                Console.WriteLine("                  ");

            }
            Console.WriteLine("ADIOOOOOOOOOOOOOOOOS");

        }
    }
}
