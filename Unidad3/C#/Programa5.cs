using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el precio del primer artículo: $");
        double precio1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio del segundo artículo: $");
        double precio2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio del tercer artículo: $");
        double precio3 = double.Parse(Console.ReadLine());

        double total = precio1 + precio2 + precio3;
        double descuento = 0;

        if (total > 1500)
        {
            descuento = total * 0.3;
        }
        else if (total >= 1000)
        {
            descuento = total * 0.2;
        }
        else if (total >= 700)
        {
            descuento = total * 0.1;
        }

        double totalPagar = total - descuento;
        Console.WriteLine("Total a pagar: $" + totalPagar);
    }
}
