
package com.mycompany.programa2;
import java.util.Scanner;

public class programa2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double suma = 0;
        for (int i = 1; i <= 6; i++) {
            System.out.print("Ingrese la calificación " + i + ": ");
            double calificacion = scanner.nextDouble();
            suma += calificacion;
        }

        double promedio = suma / 6;
        if (promedio >= 70) {
            System.out.println("Aprobado con un promedio de " + promedio);
        } else {
            System.out.println("Reprobado con un promedio de " + promedio);
        }
    }
}