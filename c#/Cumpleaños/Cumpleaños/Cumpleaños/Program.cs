using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu fecha de nacimiento (DD MM YYYY): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcular la edad restando la fecha de nacimiento a la fecha actual
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Verificar si ya ha pasado el cumpleaños de este año
            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            // Calcular la fecha del próximo cumpleaños
            DateTime proximoCumpleanos = fechaNacimiento.AddYears(edad + 1);

            // Calcular la cantidad de días hasta el próximo cumpleaños
            TimeSpan tiempoRestante = proximoCumpleanos - fechaActual;
            int diasFaltantes = tiempoRestante.Days;

            // Verificar si hoy es el cumpleaños
            bool esCumpleanosHoy = fechaActual.Month == fechaNacimiento.Month && fechaActual.Day == fechaNacimiento.Day;

            // Mostrar la edad y días hasta el próximo cumpleaños
            Console.WriteLine($"Tienes {edad} años.");
            Console.WriteLine($"Faltan {diasFaltantes} días para tu próximo cumpleaños.");

            // Mostrar mensaje de felicitación si es el cumpleaños
            if (esCumpleanosHoy)
            {
                Console.WriteLine("¡Feliz cumpleaños!");
            }
        }
        else
        {
            Console.WriteLine("Fecha de nacimiento no válida. Por favor, ingresa una fecha en formato válido (DD MM YYYY).");
        }
    }
}
