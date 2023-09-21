import random

def juego_adivina_el_numero():
    numero_secreto = random.randint(1, 100)  # Genera un número aleatorio entre 1 y 100
    intentos = 0
    max_intentos = 10  # Puedes ajustar el número máximo de intentos aquí
    
    print("¡Bienvenido al juego Adivina el Número!")
    print(f"Adivina un número entre 1 y 100. Tienes {max_intentos} intentos.")

    while intentos < max_intentos:
        try:
            adivinanza = int(input("Introduce tu suposición: "))
        except ValueError:
            print("Por favor, introduce un número válido.")
            continue

        intentos += 1

        if adivinanza < numero_secreto:
            print("El número es mayor. Intenta de nuevo.")
        elif adivinanza > numero_secreto:
            print("El número es menor. Intenta de nuevo.")
        else:
            print(f"¡Felicidades! Adivinaste el número {numero_secreto} en {intentos} intentos.")
            break

    if intentos == max_intentos:
        print(f"Agotaste tus {max_intentos} intentos. El número secreto era {numero_secreto}. ¡Mejor suerte la próxima vez!")

if __name__ == "__main__":
    juego_adivina_el_numero()