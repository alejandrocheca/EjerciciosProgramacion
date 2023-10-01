# Pedir al usuario que ingrese dos números
numero1 = float(input("Ingresa el primer número: "))
numero2 = float(input("Ingresa el segundo número: "))

# Realizar las operaciones
suma = numero1 + numero2
resta = numero1 - numero2
multiplicacion = numero1 * numero2

# Manejar la división por cero
if numero2 != 0:
    division = numero1 / numero2
else:
    division = "No se puede dividir entre cero"

# Mostrar los resultados
print(f"Suma: {suma}")
print(f"Resta: {resta}")
print(f"Multiplicación: {multiplicacion}")
print(f"División: {division}")
