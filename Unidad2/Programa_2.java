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
        int a, b, suma;
        System.out.print("Escribe tu numero A:");
        a = sc.nextInt();
        System.out.print("Escribe tu numero B:");
        b = sc.nextInt();
        suma=a+b;
        System.out.println("Resultado: "+suma);
    }
}
