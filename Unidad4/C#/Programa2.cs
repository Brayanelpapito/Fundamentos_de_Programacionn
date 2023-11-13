using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Calif = new int[6] { 43, 23, 54, 78, 56, 34, };
            double e = 0, promedio = 0;
            for (int i = 0; i < Calif.Length; i++)
            {
                e += Calif[i];
            }
            promedio = e / 6;
            Console.WriteLine("Hola");
            Console.WriteLine("Tu promedio es " + promedio);

            if (promedio >= 60)

                Console.WriteLine("pasaste");

            else

                Console.WriteLine("reprobaste");


        }
    }
}