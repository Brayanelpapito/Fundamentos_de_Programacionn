/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa18;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa18 {

    public static void main(String[] args) {
        double salarioInicial = 1500.0;
        double incrementoAnual = 0.10;

        for (int año = 1; año <= 6; año++) {
            salarioInicial += salarioInicial * incrementoAnual;
            System.out.println("Salario en el año " + año + ": $" + salarioInicial);
        }

        System.out.println("Salario al cabo de 6 años: $" + salarioInicial);
    }
}