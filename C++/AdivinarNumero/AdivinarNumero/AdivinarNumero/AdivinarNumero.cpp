#include <iostream>

int main() {
    int numeroSecreto = 50;
    int intentos = 0;
    int intento;

    std::cout << "Adivina el numero secreto (entre 1 y 100):" << std::endl;

    while (true) {
        std::cin >> intento;
        intentos++;

        if (intento == numeroSecreto) {
            std::cout << "¡Felicidades! Adivinaste el numero en " << intentos << " intentos." << std::endl;
            break;
        }
        else if (intento < numeroSecreto) {
            std::cout << "El numero secreto es mayor. Intenta nuevamente:" << std::endl;
        }
        else {
            std::cout << "El numero secreto es menor. Intenta nuevamente:" << std::endl;
        }
    }

    return 0;
}
