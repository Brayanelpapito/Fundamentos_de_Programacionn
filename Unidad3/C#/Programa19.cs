using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números a analizar: ");
        int n = int.Parse(Console.ReadLine());

        int ceroCount = 0;
        int mayoresCeroCount = 0;
        int menoresCeroCount = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Ingrese el número #" + i + ": ");
            int numero = int.Parse(Console.ReadLine);

            if (numero == 0)
            {
                ceroCount++;
            }
            else if (numero > 0)
            {
                mayoresCeroCount++;
            }
            else
            {
                menoresCeroCount++;
            }
        }

        Console.WriteLine("Números iguales a cero: " + ceroCount);
        Console.WriteLine("Números mayores a cero: " + mayoresCeroCount);
        Console.WriteLine("Números menores a cero: " + menoresCeroCount);
    }
}
