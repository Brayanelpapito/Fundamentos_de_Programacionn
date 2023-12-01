package com.mycompany.programa3;
import java.math.*;
import java.util.Scanner;

public class Programa3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Ingrese un valor para x: ");
        double x = sc.nextDouble();
        System.out.print("Ingrese un valor para y: ");
        double y = sc.nextDouble();
        
        
        System.out.print("Resultado de la primera ecuación: "+ecua(x,y));
        System.out.print("Resultado de la segunda ecuacion: "+raiz(x,y));
        
    }
    public static double ecua (double x, double y ){
    double r=0;
    r= Math .pow(x, 4) + (2 * Math.pow (y , 4));
    return r;
}
    public static double raiz (double x, double y ){
    double r=0;
    r= Math.sqrt(Math.pow(x,4) + 5*y);
    return r;
}
    
    
}
