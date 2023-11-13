﻿using System;

class Program
{
    static void Main()
    {
        double[] numeros = { 5, 2, 8, 1, 7, 3, 9, 4, 6 };

        double media = C_Media(numeros);
        Console.WriteLine($"La media es: {media}");

        double mediana = C_Mediana(numeros);
        Console.WriteLine($"La mediana es: {mediana}");
    }

    static double C_Media(double[] array)
    {
        double suma = 0;

        foreach (double numero in array)
        {
            suma += numero;
        }

        return suma / array.Length;
    }

    static double C_Mediana(double[] array)
    {
        Array.Sort(array);

        int n = array.Length;

        if (n % 2 == 0)
        {
            double elemento1 = array[(n / 2) - 1];
            double elemento2 = array[n / 2];
            return (elemento1 + elemento2) / 2;
        }
        else
        {
            return array[n / 2];
        }
    }
}

