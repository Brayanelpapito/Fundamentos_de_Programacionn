/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa13;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa13 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        
        int c, total, num, negativos = 0, positivos=0;
        System.out.println("Escribe el total de numeros a procesar!");
        total=sc.nextInt ();
        
        for (c=1; c<=total; c++){
        System.out.println("Escribe tu numero: ");
        num=sc.nextInt();
        if (num>0) {
            positivos++;}
        else if(num<0){
          negativos++;}
                System.out.println("Cantidad de numeros Positivos="+positivos);
                System.out.println("Cantidad de numeros Negativos="+negativos);
    }
}

}
