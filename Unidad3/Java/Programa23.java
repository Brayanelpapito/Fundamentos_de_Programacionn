
package com.mycompany.programa22;
import java.util.Scanner;
public class Programa22 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int suma=0, num;
        do {
            System.out.println("Escribe el numero:");
            num=sc.nextInt();
            suma=suma+num;
           }
        while (num!=0);
        
        System.out.println("El resultado es "+suma);
    }
}
