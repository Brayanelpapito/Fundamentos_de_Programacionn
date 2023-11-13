using System;

class Program
{
    static void Main()
    {
        char respuesta;

        do
        {
            Console.WriteLine("¡Bienvenido al programa!");
            Console.Write("Presione 'n' para salir, o cualquier otra tecla para continuar: ");
            respuesta = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (respuesta != 'n');
    }
}
