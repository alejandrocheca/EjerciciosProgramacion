numeros = [0] * 5  # Lista de tamaño 5 para almacenar números
indice = 0  # Índice actual de la lista

print("Ingresa 5 números:")

while indice < 5:
    entrada = input("Ingresa un número: ")

    # Verifica si el número ingresado es válido
    try:
        numero_ingresado = int(entrada)
        numeros[indice] = numero_ingresado
        indice += 1
    except ValueError:
        print("¡El número ingresado no es válido!")

print("\nNúmeros ingresados:")

for numero in numeros:
    print(numero)

input()