using System;

class Program
{
    static void Main()
    {
        for (int employee = 1; employee <= 20; employee++)
        {
            Console.Write("Ingrese las horas trabajadas para el empleado #" + employee + ": ");
            int horasTrabajadas = int.Parse(Console.ReadLine);

            Console.Write("Ingrese el pago por hora para el empleado #" + employee + ": ");
            double pagoPorHora = double.Parse(Console.ReadLine);

            double sueldoSemanal = horasTrabajadas * pagoPorHora;
            Console.WriteLine("El sueldo semanal del empleado #" + employee + " es: $" + sueldoSemanal);
        }
    }
}
