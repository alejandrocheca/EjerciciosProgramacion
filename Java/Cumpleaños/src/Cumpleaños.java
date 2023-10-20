import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;

public class Cumpleaños {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingresa tu fecha de nacimiento (dd-mm-yyyy): ");
        String fechaNacimientoStr = scanner.nextLine();

        SimpleDateFormat dateFormat = new SimpleDateFormat("dd-MM-yyyy");
        Date fechaNacimiento;

        try {
            fechaNacimiento = dateFormat.parse(fechaNacimientoStr);
            Calendar calendarNacimiento = Calendar.getInstance();
            calendarNacimiento.setTime(fechaNacimiento);

            // Obtener la fecha actual
            Calendar fechaActual = Calendar.getInstance();

            // Calcular la edad restando la fecha de nacimiento a la fecha actual
            int edad = fechaActual.get(Calendar.YEAR) - calendarNacimiento.get(Calendar.YEAR);

            // Verificar si ya ha pasado el cumpleaños de este año
            if (fechaActual.get(Calendar.MONTH) < calendarNacimiento.get(Calendar.MONTH)
                    || (fechaActual.get(Calendar.MONTH) == calendarNacimiento.get(Calendar.MONTH)
                    && fechaActual.get(Calendar.DAY_OF_MONTH) < calendarNacimiento.get(Calendar.DAY_OF_MONTH))) {
                edad--;
            }

            // Calcular la fecha del próximo cumpleaños
            Calendar proximoCumpleanos = (Calendar) calendarNacimiento.clone();
            proximoCumpleanos.add(Calendar.YEAR, edad + 1);

            // Calcular la cantidad de días hasta el próximo cumpleaños
            long tiempoRestanteMillis = proximoCumpleanos.getTimeInMillis() - fechaActual.getTimeInMillis();
            int diasFaltantes = (int) (tiempoRestanteMillis / (1000 * 60 * 60 * 24));

            // Verificar si hoy es el cumpleaños
            boolean esCumpleanosHoy = fechaActual.get(Calendar.MONTH) == calendarNacimiento.get(Calendar.MONTH)
                    && fechaActual.get(Calendar.DAY_OF_MONTH) == calendarNacimiento.get(Calendar.DAY_OF_MONTH);

            // Mostrar la edad y días hasta el próximo cumpleaños
            System.out.println("Tienes " + edad + " años.");
            System.out.println("Faltan " + diasFaltantes + " días para tu próximo cumpleaños.");

            // Mostrar mensaje de felicitación si es el cumpleaños
            if (esCumpleanosHoy) {
                System.out.println("¡Feliz cumpleaños!");
            }
        } catch (ParseException e) {
            System.out.println("Fecha de nacimiento no válida. Por favor, ingresa una fecha en formato válido (dd-MM-yyyy).");
        }
    }
}
