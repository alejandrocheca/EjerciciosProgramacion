import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class NumerosHastaNegativo {
    public static void main(String[] args) {
        List<Integer> numeros = leerNumeros();
        System.out.println("Números ingresados: " + numeros);
    }

    public static List<Integer> leerNumeros() {
        List<Integer> numeros = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);

        System.out.println("Ingrese números (ingrese un número negativo para finalizar):");

        int numero;
        while (true) {
            numero = scanner.nextInt();
            if (numero < 0) {
                break;
            }
            numeros.add(numero);
        }

        scanner.close();
        return numeros;
    }
}