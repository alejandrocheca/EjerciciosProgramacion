#include <iostream>
#include <random>

void jugarAdivinaNumero() {
    std::random_device rd;
    std::mt19937 gen(rd());
    std::uniform_int_distribution<int> distribucion(1, 100);
    int numeroSecreto = distribucion(gen);

    std::cout << "Adivina el numero secreto (entre 1 y 100):" << std::endl;

    while (true) {
        int intento;
        std::cin >> intento;

        if (intento == numeroSecreto) {
            std::cout << "¡Felicidades! Adivinaste el numero secreto." << std::endl;
            break;
        }
        else if (intento < numeroSecreto) {
            std::cout << "El numero secreto es mayor. Intenta nuevamente:" << std::endl;
        }
        else {
            std::cout << "El numero secreto es menor. Intenta nuevamente:" << std::endl;
        }
    }
}

int main() {
    jugarAdivinaNumero();
    return 0;
}
