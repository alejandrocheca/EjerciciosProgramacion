// Clase principal que contiene el método main
public class Main {
    public static void main(String[] args) {
        // Crear una nueva instancia de Persona
        Persona persona1 = new Persona("Juan", 30, "Masculino");

        // Imprimir la información de la persona
        System.out.println("Información de la persona:");
        persona1.imprimirInformacion();

        // Cambiar la edad de la persona
        persona1.setEdad(35);

        // Imprimir la información actualizada
        System.out.println("\nInformación de la persona actualizada:");
        persona1.imprimirInformacion();
    }
}