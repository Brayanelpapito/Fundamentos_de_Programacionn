package com.mycompany.programa24;
import java.util.Scanner;
public class Programa24 {

  

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        while (true) {
            System.out.print("Ingrese un número (ingrese un número negativo para salir): ");
            int numero = sc.nextInt();
            
            if (numero < 0) {
                System.out.println("Programa terminado.");
                break;
            }
            
            if (numero % 2 == 0) {
                System.out.println("El número es par.");
            } else {
                System.out.println("El número es impar.");
            }
        }
        
        
    }
}