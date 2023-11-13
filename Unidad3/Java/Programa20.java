package com.mycompany.programa20;

import java.util.Scanner;
public class Programa20 {

    public static void main(String[] args) {
        double ahorroDiario = 3.0;
        double ahorroAnual = 0.0;

        for (int dia = 1; dia <= 365; dia++) {
            System.out.println("Ahorro el día " + dia + ": $" + ahorroDiario);
            ahorroAnual += ahorroDiario;
            ahorroDiario *= 3; 
        }

        System.out.println("Ahorro total en un año: $" + ahorroAnual);
    }
}