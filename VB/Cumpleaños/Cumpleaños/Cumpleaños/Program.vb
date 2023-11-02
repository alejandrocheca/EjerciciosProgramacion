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

            ' Verificar si ya ha pasado el cumplea�os de este a�o
            If fechaActual.Month < fechaNacimiento.Month OrElse (fechaActual.Month = fechaNacimiento.Month AndAlso fechaActual.Day < fechaNacimiento.Day) Then
                edad -= 1
            End If

            ' Calcular la fecha del pr�ximo cumplea�os
            Dim proximoCumpleanos As DateTime = fechaNacimiento.AddYears(edad + 1)

            ' Calcular la cantidad de d�as hasta el pr�ximo cumplea�os
            Dim tiempoRestante As TimeSpan = proximoCumpleanos - fechaActual
            Dim diasFaltantes As Integer = tiempoRestante.Days

            ' Verificar si hoy es el cumplea�os
            Dim esCumpleanosHoy As Boolean = fechaActual.Month = fechaNacimiento.Month AndAlso fechaActual.Day = fechaNacimiento.Day

            ' Mostrar la edad y d�as hasta el pr�ximo cumplea�os
            Console.WriteLine($"Tienes {edad} a�os.")
            Console.WriteLine($"Faltan {diasFaltantes} d�as para tu pr�ximo cumplea�os.")

            ' Mostrar mensaje de felicitaci�n si es el cumplea�os
            If esCumpleanosHoy Then
                Console.WriteLine("�Feliz cumplea�os!")
            End If
        Else
            Console.WriteLine("Fecha de nacimiento no v�lida. Por favor, ingresa una fecha en formato v�lido (DD MM YYYY).")
        End If
    End Sub
End Class
