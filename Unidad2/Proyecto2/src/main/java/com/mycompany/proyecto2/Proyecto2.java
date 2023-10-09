/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.proyecto2;
import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Proyecto2 {

    public static void main(String[] args) {
        Scanner sc= new Scanner (System.in);
        int  c1, c2, c3, c4, c5, c6, Promedio;

        System.out.print("Escribe tu Calificación 1:");
        c1 = sc.nextInt();
        System.out.print("Escribe tu Calificación 2:");
        c2 = sc.nextInt();
        System.out.print("Escribe tu Calificación 3:");
        c3 = sc.nextInt();
        System.out.print("Escribe tu Calificación 4:");
        c4 = sc.nextInt();
        System.out.print("Escribe tu Calificación 5:");
        c5 = sc.nextInt();
        System.out.print("Escribe tu Calificación 6:");
        c6 = sc.nextInt();
        Promedio=(c1+c2+c3+c4+c5+c6)/6;
        System.out.println("Hola: ");
        System.out.println("Tu Promedio Es: "+Promedio);
    }
}