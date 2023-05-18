import java.util.Scanner;

public class AdivinarNumero {
    public static void main(String[] args) {
        int numeroSecreto = 50;
        int intentos = 0;
        int intento;

        Scanner scanner = new Scanner(System.in);

        System.out.println("Adivina el número secreto (entre 1 y 100):");

        while (true) {
            intento = scanner.nextInt();
            intentos++;

            if (intento == numeroSecreto) {
                System.out.println("¡Felicidades! Adivinaste el número en " + intentos + " intentos.");
                break;
            } else if (intento < numeroSecreto) {
                System.out.println("El número secreto es mayor. Intenta nuevamente:");
            } else {
                System.out.println("El número secreto es menor. Intenta nuevamente:");
            }
        }

        scanner.close();
    }
}
