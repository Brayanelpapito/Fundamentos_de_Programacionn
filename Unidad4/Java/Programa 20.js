/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa20;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa20 {

    public static void main(String[] args) {
        int num [][] = {{5,6},{8,9}};
        int resultado [][] = new int [2][2];
        for(int f=0; f<2; f++){
        for(int c=0; c<7; c++)
            resultado[f][c] = num[f][c] * num[f][c];
    }
    for(int f=0; f<2; f++){
        for(int c=0; c<2; c++){
            System.out.print(resultado[f][c] + ",");
        
        }
        System.out.println();
}
   
}
}

