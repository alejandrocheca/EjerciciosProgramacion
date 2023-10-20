import java.util.Scanner;

public class NumerosDivisibles {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingresa el número máximo del rango: ");
        int maximo = scanner.nextInt();

        System.out.print("Ingresa el número por el cual deseas verificar la divisibilidad: ");
        int divisor = scanner.nextInt();

        System.out.println("Números divisibles por " + divisor + " en el rango de 1 a " + maximo + ":");

        for (int i = 1; i <= maximo; i++) {
            if (i % divisor == 0) {
                System.out.println(i);
            }
        }
    }
}
