#include <iostream>
#include <string>

std::string eliminarLetrasDuplicadas(const std::string& cadena) {
    if (cadena.empty()) {
        return cadena;
    }

    std::string resultado;
    resultado += cadena[0]; // Agregar el primer carácter

    for (size_t i = 1; i < cadena.length(); i++) {
        if (cadena[i] != cadena[i - 1]) {
            resultado += cadena[i];
        }
    }

    return resultado;
}

int main() {
    std::string cadenaOriginal;

    std::cout << "Ingresa una cadena de texto: ";
    std::cin >> cadenaOriginal;

    std::string cadenaSinDuplicados = eliminarLetrasDuplicadas(cadenaOriginal);

    std::cout << "Cadena sin letras duplicadas seguidas: " << cadenaSinDuplicados << std::endl;

    return 0;
}
