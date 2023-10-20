def eliminar_letras_repetidas(texto):
    resultado = []
    letra_anterior = '\0'  # Carácter nulo para la primera letra

    for letra in texto:
        if letra != letra_anterior:
            resultado.append(letra)
        letra_anterior = letra

    return ''.join(resultado)

if __name__ == "__main__":
    texto = input("Ingresa un texto:\n")
    texto_sin_letras_repetidas = eliminar_letras_repetidas(texto)

    print("Texto sin letras repetidas:")
    print(texto_sin_letras_repetidas)

    input()
