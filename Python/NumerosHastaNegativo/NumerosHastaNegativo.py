maximo_numeros = 100
numeros = [0] * maximo_numeros  # Lista para almacenar números
cantidad_numeros = 0  # Cantidad actual de números ingresados

print("Ingresa números para almacenar en la lista. Ingresa un número negativo para finalizar.")

# Ingreso de números en la lista
while cantidad_numeros < maximo_numeros:
    entrada = input("Ingresa un número: ")

    try:
        numero_ingresado = int(entrada)

        # Verifica si el número ingresado es negativo para finalizar el programa
        if numero_ingresado < 0:
            break

        numeros[cantidad_numeros] = numero_ingresado
        cantidad_numeros += 1
    except ValueError:
        print("¡El número ingresado no es válido!")

print("\nNúmeros ingresados en el orden en que fueron ingresados:")

# Imprime los números ingresados en el orden en que fueron ingresados
for i in range(cantidad_numeros):
    print(numeros[i])

print("\nNúmeros ingresados en orden ascendente:")

# Ordena los números de forma ascendente y los imprime
numeros_ordenados_ascendente = sorted(numeros[:cantidad_numeros])
for numero in numeros_ordenados_ascendente:
    print(numero)

print("\nNúmeros ingresados en orden descendente:")

# Ordena los números de forma descendente y los imprime
numeros_ordenados_descendente = sorted(numeros[:cantidad_numeros], reverse=True)
for numero in numeros_ordenados_descendente:
    print(numero)

input()