def ingresar_numeros():
    numeros = []
    continuar = True

    while continuar:
        try:
            entrada = input("Ingrese un número (0 para terminar): ")
            numero = int(entrada)

            if numero == 0:
                continuar = False
            else:
                numeros.append(numero)
        except ValueError:
            print("Entrada inválida. Por favor, ingrese un número válido.")

    return numeros

if __name__ == "__main__":
    print("Ingresar Números (Ingrese 0 para terminar)")
    print("========================================")
    print()

    numeros = ingresar_numeros()

    print()
    print(f"Cantidad de números ingresados: {len(numeros)}")

    print()
    input("Presione cualquier tecla para salir.")