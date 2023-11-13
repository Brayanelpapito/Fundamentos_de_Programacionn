
package com.mycompany.programa4;


public class Programa4 {
    public static void main(String[] args) {
        int[] numeros = { 5, -2, 10, -8, 3, -1, 7 };

        int totalN = contarN(numeros);

        System.out.println("El total de números negativos es: " + totalN);
    }

    static int contarN(int[] array) {
        int contador = 0;

        for (int numero : array) {
            if (numero < 0) {
                contador++;
            }
        }

        return contador;
    }
}
