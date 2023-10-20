import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class EjemploWhile {
    public static void main(String[] args) {
        System.out.println("Ingresar Números (Ingrese 0 para terminar)");
        System.out.println("========================================");
        System.out.println();

        List<Integer> numeros = ingresarNumeros();

        System.out.println();
        System.out.println("Cantidad de números ingresados: " + numeros.size());

        System.out.println();
        System.out.println("Presione cualquier tecla para salir.");
        new Scanner(System.in).nextLine();
    }

    static List<Integer> ingresarNumeros() {
        List<Integer> numeros = new ArrayList<>();
        int numero;
        boolean continuar = true;

        while (continuar) {
            System.out.print("Ingrese un número (0 para terminar): ");
            Scanner scanner = new Scanner(System.in);
            String input = scanner.nextLine();

            try {
                numero = Integer.parseInt(input);

                if (numero == 0) {
                    continuar = false;
                } else {
                    numeros.add(numero);
                }
            } catch (NumberFormatException e) {
                System.out.println("Entrada inválida. Por favor, ingrese un número válido.");
            }
        }

        return numeros;
    }
}
