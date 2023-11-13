using System;

class Program
{
    static void Main()
    {
        double ahorroDiario = 3.0;
        double ahorroAnual = 0.0;

        for (int dia = 1; dia <= 365; dia++)
        {
            Console.WriteLine("Ahorro el día " + dia + ": $" + ahorroDiario);
            ahorroAnual += ahorroDiario;
            ahorroDiario *= 3;  // El ahorro se triplica cada día
        }

        Console.WriteLine("Ahorro total en un año: $" + ahorroAnual);
    }
}
