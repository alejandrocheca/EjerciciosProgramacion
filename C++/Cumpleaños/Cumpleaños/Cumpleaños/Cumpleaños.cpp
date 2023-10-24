#include <iostream>
#include <ctime>
#include <string>
#include <sstream>
#include <iomanip>

int main() {
    std::cout << "Ingresa tu fecha de nacimiento (DD MM YYYY): ";
    std::string input;
    std::getline(std::cin, input);

    // Convertir la entrada a una fecha
    struct std::tm fechaNacimiento = {};
    std::istringstream ss(input);
    ss >> std::get_time(&fechaNacimiento, "%d %m %Y");

    if (!ss.fail()) {
        // Obtener la fecha actual en el huso horario local
        time_t t = std::time(nullptr);
        struct std::tm fechaActual = *std::localtime(&t);

        // Calcular la edad restando el año de nacimiento al año actual
        int edad = fechaActual.tm_year + 1900 - fechaNacimiento.tm_year;

        // Verificar si ya ha pasado el cumpleaños de este año
        if (fechaActual.tm_mon < fechaNacimiento.tm_mon || (fechaActual.tm_mon == fechaNacimiento.tm_mon && fechaActual.tm_mday < fechaNacimiento.tm_mday)) {
            edad--;
        }

        // Calcular la fecha del próximo cumpleaños
        struct std::tm proximoCumpleanos = fechaNacimiento;
        proximoCumpleanos.tm_year = fechaActual.tm_year;
        if (fechaActual.tm_mon > fechaNacimiento.tm_mon || (fechaActual.tm_mon == fechaNacimiento.tm_mon && fechaActual.tm_mday >= fechaNacimiento.tm_mday)) {
            proximoCumpleanos.tm_year++;
        }

        // Calcular la cantidad de días hasta el próximo cumpleaños
        time_t tiempoProximoCumpleanos = std::mktime(&proximoCumpleanos);
        int diasFaltantes = static_cast<int>((tiempoProximoCumpleanos - t) / (60 * 60 * 24));

        // Verificar si hoy es el cumpleaños
        bool esCumpleanosHoy = fechaActual.tm_mon == fechaNacimiento.tm_mon && fechaActual.tm_mday == fechaNacimiento.tm_mday;

        // Mostrar la edad y días hasta el próximo cumpleaños
        std::cout << "Tienes " << edad << " años." << std::endl;
        std::cout << "Faltan " << diasFaltantes << " días para tu próximo cumpleaños." << std::endl;

        // Mostrar mensaje de felicitación si es el cumpleaños
        if (esCumpleanosHoy) {
            std::cout << "¡Feliz cumpleaños!" << std::endl;
        }
    }
    else {
        std::cout << "Fecha de nacimiento no válida. Por favor, ingresa una fecha en formato válido (DD MM YYYY)." << std::endl;
    }

    return 0;
}
