import java.util.Random;
import java.util.Scanner;

public class AdivinarNumeroAleatorio {
    public static void main(String[] args) {
        jugarAdivinaNumero();
    }

    public static void jugarAdivinaNumero() {
        Random random = new Random();
        int numeroSecreto = random.nextInt(100) + 1;

        Scanner scanner = new Scanner(System.in);

        System.out.println("Adivina el número secreto (entre 1 y 100):");

        while (true) {
            int intento = scanner.nextInt();

            if (intento == numeroSecreto) {
                System.out.println("¡Felicidades! Adivinaste el número secreto.");
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
