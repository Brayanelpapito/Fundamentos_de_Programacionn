using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números naturales positivos: ");
        int cantidadNumeros = int.Parse(Console.ReadLine);

        for (int i = 1; i <= cantidadNumeros; i++)
        {
            Console.Write("Ingrese un número natural positivo: ");
            int numero = int.Parse(Console.ReadLine);

            if (numero > 0)
            {
                double cubo = Math.Pow(numero, 3);
                Console.WriteLine("El cubo de " + numero + " es: " + cubo);
            }
            else
            {
                Console.WriteLine("El número ingresado no es válido. Debe ser un número natural positivo.");
                i--; // Restar 1 al contador para volver a ingresar un número válido.
            }
        }
    }
}
