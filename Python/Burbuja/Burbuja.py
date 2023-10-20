def ordenacion_burbuja(arr):
    n = len(arr)
    
    for i in range(n):
        # Bandera para optimización
        intercambiado = False
        
        # Últimos i elementos ya están en su lugar
        for j in range(0, n-i-1):
            # Intercambiar si el elemento encontrado es mayor que el siguiente elemento
            if arr[j] > arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]  # Intercambio
                intercambiado = True
        
        # Si no se ha realizado ningún intercambio en esta pasada, el arreglo ya está ordenado
        if not intercambiado:
            break

# Ejemplo de uso
arr = [64, 34, 25, 12, 22, 11, 90]
ordenacion_burbuja(arr)
print("Arreglo ordenado:")
print(arr)
