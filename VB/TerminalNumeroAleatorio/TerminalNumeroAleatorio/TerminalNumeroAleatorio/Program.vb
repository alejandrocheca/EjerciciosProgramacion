Imports System

Module Program
    Sub Main()
        Dim rnd As New Random()
        Dim numeroObjetivo As Integer = rnd.Next(1, 101) ' Genera un número aleatorio entre 1 y 100
        Dim intentos As Integer = AdivinarNumero(numeroObjetivo)
        Console.WriteLine("Se adivinó el número " & numeroObjetivo & " en " & intentos & " intentos.")
    End Sub

    Function AdivinarNumero(numeroObjetivo As Integer) As Integer
        Dim intentos As Integer = 0
        Dim numeroAdivinado As Integer

        Do
            ' Generar un número aleatorio para adivinar
            Dim rnd As New Random()
            numeroAdivinado = rnd.Next(1, 101) ' Genera un número aleatorio entre 1 y 100

            ' Incrementar el contador de intentos
            intentos += 1

            ' Mostrar el número adivinado
            Console.WriteLine("Intento " & intentos & ": " & numeroAdivinado)

        Loop While numeroAdivinado <> numeroObjetivo

        Return intentos
    End Function
End Module
