#include <iostream>
#include <string>
#include <map>
#include <cctype>

int main() {
    std::cout << "Ingresa un texto: ";
    std::string texto;
    std::getline(std::cin, texto);

    // Contar la cantidad total de caracteres
    int totalCaracteres = texto.length();

    // Contar la cantidad de signos ortograficos (no letras ni numeros)
    int signosOrtograficos = 0;
    for (char c : texto) {
        if (!std::isalnum(c) && !std::isspace(c)) {
            signosOrtograficos++;
        }
    }

    // Crear un mapa para almacenar la frecuencia de cada letra y número
    std::map<char, int> frecuenciaCaracteres;

    // Iterar a través del texto para contar letras y numeros
    for (char caracter : texto) {
        if (std::isalnum(caracter)) {
            char c = std::tolower(caracter); // Tratar las letras y numeros como minúsculas
            frecuenciaCaracteres[c]++;
        }
    }

    // Mostrar resultados
    std::cout << "Cantidad total de caracteres: " << totalCaracteres << std::endl;
    std::cout << "Cantidad de signos ortograficos: " << signosOrtograficos << std::endl;

    std::cout << "Frecuencia de letras y numeros (en orden alfabetico o numérico):" << std::endl;
    for (const auto& par : frecuenciaCaracteres) {
        std::cout << par.first << ": " << par.second << std::endl;
    }

    return 0;
}
