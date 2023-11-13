package com.mycompany.programa21;

import java.util.Scanner;
public class Programa21 {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int cantidadNumeros;
        int suma = 0;

        System.out.print("Ingrese la cantidad de números a procesar: ");
        cantidadNumeros = input.nextInt();

        for (int i = 1; i <= cantidadNumeros; i++) {
            System.out.print("Ingrese un número natural positivo: ");
            int numero = input.nextInt();

            if (numero > 0) {
                suma += numero;
            } else {
                System.out.println("El número ingresado no es válido. Debe ser un número natural positivo.");
                i--; 
            }
        }

        System.out.println("La suma de los " + cantidadNumeros + " números naturales positivos ingresados es: " + suma);
    }
}