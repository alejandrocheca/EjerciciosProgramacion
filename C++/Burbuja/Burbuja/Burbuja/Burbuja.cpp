#include <iostream>

void Burbuja(int arr[], int n) {
    bool swapped;

    for (int i = 0; i < n - 1; i++) {
        swapped = false;

        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                // Intercambiar los elementos
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                swapped = true;
            }
        }

        // Si no se ha realizado ningún intercambio en esta pasada, el arreglo ya está ordenado
        if (!swapped)
            break;
    }
}

void PrintArray(int arr[], int n) {
    for (int i = 0; i < n; i++) {
        std::cout << arr[i] << " ";
    }
    std::cout << std::endl;
}

int main() {
    int array[] = { 5, 2, 9, 1, 3 };
    int n = sizeof(array) / sizeof(array[0]);

    std::cout << "Array original:" << std::endl;
    PrintArray(array, n);

    Burbuja(array, n);

    std::cout << "Array ordenado:" << std::endl;
    PrintArray(array, n);

    return 0;
}
