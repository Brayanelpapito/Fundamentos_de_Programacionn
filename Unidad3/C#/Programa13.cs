using System;

class Program
{
    static void Main()
    {
        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 1; i <= 100; i++)
        {
            Console.Write("Ingrese el número #" + i + ": ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Números positivos: " + positiveCount);
        Console.WriteLine("Números negativos: " + negativeCount);
    }
}
