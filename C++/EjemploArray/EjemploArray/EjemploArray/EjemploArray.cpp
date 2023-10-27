#include <iostream>
#include <vector>

std::vector<int> ingresarNumeros() {
    std::vector<int> numeros;
    int numero;
    bool continuar = true;

    while (continuar) {
        std::cout << "Ingrese un numero (0 para terminar): ";
        std::cin >> numero;

        if (numero == 0) {
            continuar = false;
        }
        else {
            numeros.push_back(numero);
        }
    }

    return numeros;
}

int main() {
    std::cout << "Ingresar Numeros (Ingrese 0 para terminar)" << std::endl;
    std::cout << "========================================" << std::endl;
    std::cout << std::endl;

    std::vector<int> numeros = ingresarNumeros();

    std::cout << std::endl;
    std::cout << "Cantidad de numeros ingresados: " << numeros.size() << std::endl;

    std::cout << std::endl;
    std::cout << "Presione cualquier tecla para salir." << std::endl;
    std::cin.get();
    return 0;
}
