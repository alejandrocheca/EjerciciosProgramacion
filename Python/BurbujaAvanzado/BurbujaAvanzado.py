def bubble_sort_asc(array):
    n = len(array)

    for i in range(n - 1):
        swapped = False

        for j in range(n - i - 1):
            if array[j] > array[j + 1]:
                # Intercambiar los elementos
                array[j], array[j + 1] = array[j + 1], array[j]
                swapped = True

        # Si no se ha realizado ningún intercambio en esta pasada, el array ya está ordenado
        if not swapped:
            break

def bubble_sort_desc(array):
    n = len(array)

    for i in range(n - 1):
        swapped = False

        for j in range(n - i - 1):
            if array[j] < array[j + 1]:
                # Intercambiar los elementos
                array[j], array[j + 1] = array[j + 1], array[j]
                swapped = True

        # Si no se ha realizado ningún intercambio en esta pasada, el array ya está ordenado
        if not swapped:
            break

def print_array(array):
    for element in array:
        print(element, end=" ")
    print()

def main():
    cantidad = int(input("Ingrese la cantidad de números: "))
    array = []

    for i in range(cantidad):
        numero = int(input(f"Ingrese el número {i + 1}: "))
        array.append(numero)

    print("Array original:")
    print_array(array)

    bubble_sort_asc(array)

    print("Array ordenado ascendentemente:")
    print_array(array)

    bubble_sort_desc(array)

    print("Array ordenado descendentemente:")
    print_array(array)

if __name__ == "__main__":
    main()
