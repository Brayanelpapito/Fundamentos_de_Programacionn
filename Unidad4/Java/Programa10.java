
package com.mycompany.programa10;


public class Programa10 {
    public static void main(String[] args) {
        String[] paises = { "Canadá", "México", "Brazil", "Argentina" };

        double longitudPromedio = calcular_Longitud(paises);

        System.out.printf("La longitud promedio de las palabras de los países es: %.2f%n", longitudPromedio);
    }

    static double calcular_Longitud(String[] arreglo) {
        int total_Letras = 0;
        int total_Palabras = 0;

        for (String pais : arreglo) {
            total_Letras += pais.replace(" ", "").length();
            total_Palabras += pais.split(" ").length;
        }

        double longitud_Promedio = (double) total_Letras / total_Palabras;

        return longitud_Promedio;
    }
}
