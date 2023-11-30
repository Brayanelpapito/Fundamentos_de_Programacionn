
package com.mycompany.programa15;

import java.util.Scanner;

public class Programa15 {

     public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingrese el número de filas: ");
        int filas = scanner.nextInt();
        System.out.print("Ingrese el número de columnas: ");
        int columnas = scanner.nextInt();

        double[][] matriz = new double[filas][columnas];

        System.out.println("Ingrese los elementos de la matriz:");

        for (int i = 0; i < filas; i++) {
            for (int j = 0; j < columnas; j++) {
                System.out.print("Elemento [" + (i + 1) + "][" + (j + 1) + "]: ");
                matriz[i][j] = scanner.nextDouble();
            }
        }

        System.out.println("\nMedia de cada fila:");

        for (int i = 0; i < filas; i++) {
            double suma = 0;

            for (int j = 0; j < columnas; j++) {
                suma += matriz[i][j];
            }

            double media = suma / columnas;
            System.out.println("Fila " + (i + 1) + ": " + media);
        }

        scanner.close();
    }
}
