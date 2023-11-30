using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Elige el tipo de conversion a realizar");
            Console.WriteLine("1 Temperatura C a F");
            Console.WriteLine("2 Temperatura F a K");
            Console.WriteLine("3 Medida Pulgadas a Metros");
            Console.WriteLine("4 Tiempo Horas a Segundos");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    int c;
                    Console.WriteLine("Escriba los grados a convertir");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su resultado es:" + temperaturaCF(c));
                    break;
                case 2:
                    Console.WriteLine("Tu resultado es:" + temperaturaFK());
                    break;
                case 3:
                    medida();
                    break;
                case 4:
                    tiempo();
                    break;
                default:
                    Console.WriteLine("La Opcion es Incorrecta");
                    break;
            } //Fin Switch
        }//Fin Main
        public static double temperaturaCF(double c)
        {
            double resultado = (c * 1.8) + 32;
            return resultado;
        }
        public static double temperaturaFK()
        {
            double F, resultado;
            Console.Write("Escriba la temperatura F a convertir");
            F = Convert.ToDouble(Console.ReadLine());
            resultado = (F - 32) * (5 / 9) + 273.15;
            return resultado;
        }
        public static void medida()
        {
            double P, resultado;
            Console.Write("Escriba la Medida en pulgada:");
            P = Convert.ToDouble(Console.ReadLine());
            resultado = P / 39.37;
            Console.WriteLine("Tu resultado es:" + resultado);

        }
        public static double tiempo()
        {
            double h, resultado;
            Console.Write("Escriba las Horas a convertir:");
            h = Convert.ToDouble(Console.ReadLine());
            return h * 3600;


        }

    }
}