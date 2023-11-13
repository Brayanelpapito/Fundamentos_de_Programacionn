using System;

class Program
{
    static void Main()
    {
        double salario = 1500;
        double incrementoAnual = 0.10;

        for (int año = 1; año <= 6; año++)
        {
            salario += salario * incrementoAnual;
            Console.WriteLine("Salario en el año " + año + ": $" + salario);
        }

        Console.WriteLine("Salario al cabo de 6 años: $" + salario);
    }
}
