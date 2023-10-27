#include <iostream>

int main() {
    double numero1, numero2;

    // Solicitar al usuario que ingrese dos numeros
    std::cout << "Ingresa el primer numero: ";
    std::cin >> numero1;
    std::cout << "Ingresa el segundo numero: ";
    std::cin >> numero2;

    // Realizar las operaciones matemáticas
    double suma = numero1 + numero2;
    double resta = numero1 - numero2;
    double multiplicacion = numero1 * numero2;

    // Verificar la división por cero
    double division = 0;
    if (numero2 != 0) {
        division = numero1 / numero2;
    }
    else {
        std::cout << "No se puede dividir por cero." << std::endl;
    }

    // Mostrar los resultados
    std::cout << "Suma: " << suma << std::endl;
    std::cout << "Resta: " << resta << std::endl;
    std::cout << "Multiplicacion: " << multiplicacion << std::endl;
    if (numero2 != 0) {
        std::cout << "Division: " << division << std::endl;
    }

    return 0;
}
