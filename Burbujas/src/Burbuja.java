import java.util.Arrays;
import java.util.Scanner;

public class Burbuja {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingresa la cantidad de números: ");
        int cantidadNumeros = scanner.nextInt();

        int[] numeros = new int[cantidadNumeros];

        System.out.println("Ingresa los números uno por uno:");
        for (int i = 0; i < cantidadNumeros; i++) {
            numeros[i] = scanner.nextInt();
        }

        burbujaAsc(numeros);
        System.out.println("Números ordenados ascendentemente: " + Arrays.toString(numeros));
        burbujaDesc(numeros);
        System.out.println("Números ordenados descendentemente: " + Arrays.toString(numeros));
        
    }

    public static void burbujaAsc(int[] arr) {
        int n = arr.length;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    // Intercambiar elementos
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    public static void burbujaDesc(int[] arr) {
        int n = arr.length;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] < arr[j + 1]) {
                    // Intercambiar elementos
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    
}