package com.mycompany.programa25;
import java.util.Scanner;
public class Programa25 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while (true) {
            System.out.print("Ingrese el primer número (o 'q' para salir): ");
            String input = sc.nextLine();

            if (input.equals("q")) {
                System.out.println("Calculadora finalizada.");
                break;
            }

            double numero1 = Double.parseDouble(input);

            System.out.print("Ingrese el operador (+, -, *, /): ");
            char operador = sc.nextLine().charAt(0);

            System.out.print("Ingrese el segundo número: ");
            double numero2 = sc.nextDouble();
            sc.nextLine();  // Consumir la nueva línea

            double resultado ;

            switch (operador) {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if (numero2 != 0) {
                        resultado = numero1 / numero2;
                    } else {
                        System.out.println("No se puede dividir por cero.");
                        continue;  // Volver a solicitar la entrada
                    }
                    break;
                default:
                    System.out.println("Operador no válido.");
                    continue;  // Volver a solicitar la entrada
            }

            System.out.println("Resultado: " + resultado);
        }
    }
}