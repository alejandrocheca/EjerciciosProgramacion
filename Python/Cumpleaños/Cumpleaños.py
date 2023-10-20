from datetime import datetime

# Función para calcular la edad y los días restantes para el próximo cumpleaños
def calcular_edad_y_dias_restantes(fecha_nacimiento):
    # Obtener la fecha actual
    fecha_actual = datetime.now()
    
    # Convertir la fecha de nacimiento a un objeto datetime
    fecha_nacimiento = datetime.strptime(fecha_nacimiento, "%d-%m-%Y")
    
    # Calcular la diferencia de años
    diferencia_anios = fecha_actual.year - fecha_nacimiento.year
    
    # Comprobar si ya pasó el cumpleaños de este año
    if (fecha_actual.month, fecha_actual.day) < (fecha_nacimiento.month, fecha_nacimiento.day):
        diferencia_anios -= 1
    
    # Calcular la fecha del próximo cumpleaños
    proximo_cumple = datetime(fecha_actual.year, fecha_nacimiento.month, fecha_nacimiento.day)
    
    # Calcular los días restantes para el próximo cumpleaños
    dias_restantes = (proximo_cumple - fecha_actual).days
    
    return diferencia_anios, dias_restantes

# Pedir al usuario que ingrese la fecha de nacimiento
fecha_nacimiento = input("Ingresa tu fecha de nacimiento (dd-mm-yyyy): ")

# Calcular la edad y los días restantes
edad, dias_restantes = calcular_edad_y_dias_restantes(fecha_nacimiento)

# Obtener la fecha actual
fecha_actual = datetime.now()

# Comprobar si el cumpleaños es hoy
es_cumple_hoy = (fecha_actual.strftime("%d-%m-%Y") == fecha_nacimiento)

# Mostrar la edad y los días restantes
print(f"Tienes {edad} años.")
if es_cumple_hoy:
    print("¡Feliz cumpleaños!")
else:
    print(f"Faltan {dias_restantes} días para tu próximo cumpleaños.")
