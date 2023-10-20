# Pedir al usuario que ingrese un texto
texto = input("Ingresa un texto: ")

# Contar la cantidad total de caracteres
cantidad_total_caracteres = len(texto)

# Crear un diccionario para contar la cantidad de cada letra
conteo_letras = {}

# Recorrer el texto y contar las letras
for letra in texto:
    if letra.isalpha():  # Verificar si el carácter es una letra
        letra = letra.lower()  # Convertir la letra a minúscula para contar sin distinción de mayúsculas/minúsculas
        if letra in conteo_letras:
            conteo_letras[letra] += 1
        else:
            conteo_letras[letra] = 1

# Mostrar la cantidad total de caracteres
print(f"La cantidad total de caracteres en el texto es: {cantidad_total_caracteres}")

# Mostrar la cantidad de cada letra
print("Cantidad de cada letra:")
for letra, cantidad in conteo_letras.items():
    print(f"{letra}: {cantidad}")
