
package com.mycompany.programa2;


import java.util.Scanner;

public class Programa2 {
    public static void main(String[] args) {

        double[] calificaciones = new double[10];
        
        Scanner sc = new Scanner(System.in);

     
        for (int i = 0; i < 10; i++) {
            System.out.print("Ingrese la calificación " + (i + 1) + ": ");
            calificaciones[i] = Double.parseDouble(sc.nextLine());
        }

   
        double suma = 0;
        for (int i = 0; i < 10; i++) {
            suma += calificaciones[i];
        }

        double promedio = suma / 10;

        System.out.println("El promedio de las calificaciones es: " + promedio);

        sc.close();
    }
}

