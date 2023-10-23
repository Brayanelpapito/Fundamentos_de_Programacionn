
package com.mycompany.programa5;
import java.util.Scanner;

public class programa5 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingrese el precio del primer artículo: $");
        double precio1 = scanner.nextDouble();
        System.out.print("Ingrese el precio del segundo artículo: $");
        double precio2 = scanner.nextDouble();
        System.out.print("Ingrese el precio del tercer artículo: $");
        double precio3 = scanner.nextDouble();

        double total = precio1 + precio2 + precio3;
        double descuento = 0;

        if (total > 1500) {
            descuento = total * 0.3;
        } else if (total >= 1000) {
            descuento = total * 0.2;
        } else if (total >= 700) {
            descuento = total * 0.1;
        }

        double totalPagar = total - descuento;
        System.out.println("Total a pagar: $" + totalPagar);
    }
}