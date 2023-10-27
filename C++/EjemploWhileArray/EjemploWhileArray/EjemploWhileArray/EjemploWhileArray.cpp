#include <iostream>
#include <vector>

int main() {
    std::cout << "Ingrese la cantidad de numeros del arreglo: ";
    int cantidad;
    std::cin >> cantidad;

    std::vector<int> arreglo(cantidad);

    std::cout << "Ingrese los elementos del arreglo:" << std::endl;
    for (int i = 0; i < cantidad; i++) {
        std::cin >> arreglo[i];
    }

    std::cout << "Elementos del arreglo:" << std::endl;
    for (int j = 0; j < cantidad; j++) {
        std::cout << arreglo[j] << std::endl;
    }

    return 0;
}
