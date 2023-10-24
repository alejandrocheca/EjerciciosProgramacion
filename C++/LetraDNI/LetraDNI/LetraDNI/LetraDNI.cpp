#include <iostream>
#include <string>

char CalcularLetraDNI(int numero) {
    std::string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
    int indice = numero % 23;
    return letras[indice];
}

int main() {
    std::cout << "Introduce el numero de DNI (sin la letra): ";
    std::string numeroDNI;
    std::cin >> numeroDNI;

    try {
        int numero = std::stoi(numeroDNI);
        char letra = CalcularLetraDNI(numero);
        std::cout << "La letra correspondiente al número de DNI " << numero << " es: " << letra << std::endl;
    }
    catch (const std::invalid_argument& e) {
        std::cout << "El número de DNI no es válido. Debe ser un número entero." << std::endl;
    }

    return 0;
}
