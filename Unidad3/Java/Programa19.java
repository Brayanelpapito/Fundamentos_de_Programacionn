package com.mycompany.programa19;
import java.util.Scanner;

public class Programa19 {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Ingrese la cantidad de números a analizar: ");
        int n = input.nextInt();

        int ceroCount = 0;
        int mayoresCero = 0;
        int menoresCero = 0;

        for (int i = 1; i <= n; i++) {
            System.out.print("Ingrese el número #" + i + ": ");
            int numero = input.nextInt();

            if (numero == 0) {
                ceroCount++;
            } else if (numero > 0) {
                mayoresCero++;
            } else {
                menoresCero++;
            }
        }

        System.out.println("Números iguales a cero: " + ceroCount);
        System.out.println("Números mayores a cero: " + mayoresCero);
        System.out.println("Números menores a cero: " + menoresCero);
    }
}