Imports System

Class Program
    Shared Sub Main()
        Dim fechaNacimiento As DateTime ' Declarar la variable de fecha de nacimiento

        Console.Write("Ingresa tu fecha de nacimiento (DD MM YYYY): ")
        If DateTime.TryParse(Console.ReadLine(), fechaNacimiento) Then ' Almacenar la fecha en la variable
            ' Obtener la fecha actual
            Dim fechaActual As DateTime = DateTime.Now

            ' Calcular la edad restando la fecha de nacimiento a la fecha actual
            Dim edad As Integer = fechaActual.Year - fechaNacimiento.Year

            ' Verificar si ya ha pasado el cumpleaños de este año
            If fechaActual.Month < fechaNacimiento.Month OrElse (fechaActual.Month = fechaNacimiento.Month AndAlso fechaActual.Day < fechaNacimiento.Day) Then
                edad -= 1
            End If

            ' Calcular la fecha del próximo cumpleaños
            Dim proximoCumpleanos As DateTime = fechaNacimiento.AddYears(edad + 1)

            ' Calcular la cantidad de días hasta el próximo cumpleaños
            Dim tiempoRestante As TimeSpan = proximoCumpleanos - fechaActual
            Dim diasFaltantes As Integer = tiempoRestante.Days

            ' Verificar si hoy es el cumpleaños
            Dim esCumpleanosHoy As Boolean = fechaActual.Month = fechaNacimiento.Month AndAlso fechaActual.Day = fechaNacimiento.Day

            ' Mostrar la edad y días hasta el próximo cumpleaños
            Console.WriteLine($"Tienes {edad} años.")
            Console.WriteLine($"Faltan {diasFaltantes} días para tu próximo cumpleaños.")

            ' Mostrar mensaje de felicitación si es el cumpleaños
            If esCumpleanosHoy Then
                Console.WriteLine("¡Feliz cumpleaños!")
            End If
        Else
            Console.WriteLine("Fecha de nacimiento no válida. Por favor, ingresa una fecha en formato válido (DD MM YYYY).")
        End If
    End Sub
End Class
