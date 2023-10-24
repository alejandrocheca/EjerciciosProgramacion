#include <iostream>
#include <vector>

void BurbujaASC(std::vector<int>& array) {
    int n = array.size();
    bool swapped;

    for (int i = 0; i < n - 1; i++) {
        swapped = false;

        for (int j = 0; j < n - i - 1; j++) {
            if (array[j] > array[j + 1]) {
                // Intercambiar los elementos
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swapped = true;
            }
        }

        // Si no se ha realizado ningún intercambio en esta pasada, el array ya está ordenado
        if (!swapped)
            break;
    }
}

void BurbujaDESC(std::vector<int>& array) {
    int n = array.size();
    bool swapped;

    for (int i = 0; i < n - 1; i++) {
        swapped = false;

        for (int j = 0; j < n - i - 1; j++) {
            if (array[j] < array[j + 1]) {
                // Intercambiar los elementos
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swapped = true;
            }
        }

        // Si no se ha realizado ningún intercambio en esta pasada, el array ya está ordenado
        if (!swapped)
            break;
    }
}

void PrintArray(const std::vector<int>& array) {
    for (int element : array) {
        std::cout << element << " ";
    }
    std::cout << std::endl;
}

int main() {
    std::cout << "Ingrese la cantidad de numeros: ";
    int cantidad;
    std::cin >> cantidad;

    std::vector<int> array(cantidad);

    for (int i = 0; i < cantidad; i++) {
        std::cout << "Ingrese el numero " << i + 1 << ": ";
        std::cin >> array[i];
    }

    std::cout << "Array original:" << std::endl;
    PrintArray(array);

    BurbujaASC(array);

    std::cout << "Array ordenado ascendentemente:" << std::endl;
    PrintArray(array);

    BurbujaDESC(array);

    std::cout << "Array ordenado descendentemente:" << std::endl;
    PrintArray(array);

    return 0;
}
