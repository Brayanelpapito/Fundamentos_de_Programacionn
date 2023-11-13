using System;


public class ProgramaBases
{

    public static void Main(String[] args)
    {
        int[] edades = new int [] { 17, 19, 18, 18, 18 };


        for (int i = 0; i < edades.Length; i++)
        {
            Console.WriteLine("indice:" +i+" es:" + edades[i]);
            if (edades[i] >=18)

            Console.WriteLine("Eres mayor");

            else

            Console.WriteLine("Eres menor");


        }

    }
}
