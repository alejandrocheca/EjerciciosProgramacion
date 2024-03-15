import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Persona persona1 = new Persona("Juan", 30, "Masculino", "Calle Principal 123", "123456789", "juan@example.com");

        System.out.println("Información de la persona:");
        persona1.imprimirInformacion();

        System.out.println(persona1.esMayorDeEdad() ? "La persona es mayor de edad." : "La persona es menor de edad.");
        System.out.println(persona1.esAdultoMayor() ? "La persona es adulto mayor." : "La persona no es adulto mayor.");

        Scanner scanner = new Scanner(System.in);

        System.out.println("\nIngrese el nuevo nombre:");
        String nuevoNombre = scanner.nextLine();
        persona1.setNombre(nuevoNombre);

        System.out.println("Ingrese la nueva edad:");
        int nuevaEdad = scanner.nextInt();
        persona1.setEdad(nuevaEdad);

        scanner.nextLine(); // Consumir la nueva línea

        System.out.println("Ingrese el nuevo género:");
        String nuevoGenero = scanner.nextLine();
        persona1.setGenero(nuevoGenero);

        System.out.println("Ingrese la nueva dirección:");
        String nuevaDireccion = scanner.nextLine();
        persona1.setDireccion(nuevaDireccion);

        System.out.println("Ingrese el nuevo teléfono:");
        String nuevoTelefono = scanner.nextLine();
        persona1.setTelefono(nuevoTelefono);

        System.out.println("Ingrese el nuevo email:");
        String nuevoEmail = scanner.nextLine();
        persona1.setEmail(nuevoEmail);

        System.out.println("\nInformación de la persona actualizada:");
        persona1.imprimirInformacion();

        scanner.close();
    }
}
