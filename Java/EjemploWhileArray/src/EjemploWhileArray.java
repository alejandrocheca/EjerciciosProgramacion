import java.util.Scanner;

public class EjemploWhileArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingrese la cantidad de números del array: ");
        int cantidad = scanner.nextInt();

        int[] array = new int[cantidad];

        System.out.println("Ingrese los elementos del array:");
        int i = 0;
        while (i < cantidad) {
            array[i] = scanner.nextInt();
            i++;
        }

        System.out.println("Elementos del array:");

        int j = 0;
        while (j < cantidad) {
            System.out.println(array[j]);
            j++;
        }

        scanner.close();
    }
}
