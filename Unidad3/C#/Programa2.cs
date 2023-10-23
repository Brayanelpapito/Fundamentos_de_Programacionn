using System;

class Program
{
    static void Main()
    {
        double suma = 0;
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("Ingrese la calificación " + i + ": ");
            double calificacion = double.Parse(Console.ReadLine());
            suma += calificacion;
        }

        double promedio = suma / 6;
        if (promedio >= 70)
        {
            Console.WriteLine("Aprobaste con " + promedio);
        }
        else
        {
            Console.WriteLine("Reprobaste con " + promedio);
        }
    }
}