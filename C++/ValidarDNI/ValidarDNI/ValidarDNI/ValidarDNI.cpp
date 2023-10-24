#include <iostream>
#include <string>
#include <cctype>

bool validarDNIEspanol(const std::string& dni) {
    if (dni.size() != 9) {
        std::cout << "El DNI debe tener 9 caracteres (8 dígitos y 1 letra de control)." << std::endl;
        return false;
    }

    // Verificar que los primeros 8 caracteres son dígitos
    for (int i = 0; i < 8; i++) {
        if (!std::isdigit(dni[i])) {
            std::cout << "Los primeros 8 caracteres del DNI deben ser dígitos." << std::endl;
            return false;
        }
    }

    // Calcular la letra de control
    int numero = std::stoi(dni.substr(0, 8));
    char letrasControl[] = "TRWAGMYFPDXBNJZSQVHLCKE";
    char letraControlCalculada = letrasControl[numero % 23];

    // Comparar la letra de control calculada con la proporcionada en el DNI
    char letraDeControl = dni[8];
    if (std::toupper(letraControlCalculada) != std::toupper(letraDeControl)) {
        std::cout << "La letra de control proporcionada no coincide con la calculada." << std::endl;
        return false;
    }

    std::cout << "El DNI es valido." << std::endl;
    return true;
}

int main() {
    std::string dni;
    std::cout << "Introduce un DNI con letra de control: ";
    std::cin >> dni;

    if (validarDNIEspanol(dni)) {
        std::cout << "El DNI es valido." << std::endl;
    }
    else {
        std::cout << "El DNI no es valido." << std::endl;
    }

    return 0;
}