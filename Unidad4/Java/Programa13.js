/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa13u4;

/**
 *
 * @author LaboratorioLTI2
 */
import java.util.Scanner;
public class Programa13u4 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        float [][] temp = new float [5][7];
        for(int f=0; f<5; f++){
           for(int c=0; c<7; c++){
        
        
                System.out.println("Escribre la Temperatura en" +f+ ","+c+")");
                        temp [f][c] = sc.nextFloat();
        }

    }
        float[][] tempF = new float [5] [7];
        for(int f=0; f<5; f++){
           for(int c=0; c<7; c++){
           tempF [f][c] = (temp[f][c] * 9/5) + 32;
           System.out.println("F en ("+f+","+c+")"+tempF[f][c]);
           
           }
                   System.out.println();
        }
}
}