Imports System

Module Program
    Sub Main()
        Dim numeroObjetivo As Integer = 42
        Dim intentos As Integer = AdivinarNumero(numeroObjetivo)
        Console.WriteLine("Se adivin� el n�mero " & numeroObjetivo & " en " & intentos & " intentos.")
    End Sub

    Function AdivinarNumero(numeroObjetivo As Integer) As Integer
        Dim intentos As Integer = 0
        Dim numeroAdivinado As Integer

        Do
            ' Generar un n�mero aleatorio para adivinar
            Dim rnd As New Random()
            numeroAdivinado = rnd.Next(1, 101) ' Suponemos que el n�mero est� entre 1 y 100

            ' Incrementar el contador de intentos
            intentos += 1

            ' Mostrar el n�mero adivinado
            Console.WriteLine("Intento " & intentos & ": " & numeroAdivinado)

        Loop While numeroAdivinado <> numeroObjetivo

        Return intentos
    End Function
End Module
