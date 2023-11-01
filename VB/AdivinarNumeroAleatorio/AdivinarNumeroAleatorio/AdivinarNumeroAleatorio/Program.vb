Imports System

Module Program
    Sub Main()
        Dim numeroObjetivo As Integer = GenerarNumeroAleatorio()
        Dim intentos As Integer = AdivinarNumero(numeroObjetivo)
        Console.WriteLine("�Felicidades! Adivinaste el n�mero " & numeroObjetivo & " en " & intentos & " intentos.")
    End Sub

    Function GenerarNumeroAleatorio() As Integer
        Dim rnd As New Random()
        Return rnd.Next(1, 101) ' Genera un n�mero aleatorio entre 1 y 100
    End Function

    Function AdivinarNumero(numeroObjetivo As Integer) As Integer
        Dim intentos As Integer = 0
        Dim numeroAdivinado As Integer

        Console.WriteLine("Adivina el n�mero entre 1 y 100:")

        Do
            If Integer.TryParse(Console.ReadLine(), numeroAdivinado) Then
                intentos += 1

                If numeroAdivinado < numeroObjetivo Then
                    Console.WriteLine("El n�mero es mayor. Intento #" & intentos)
                ElseIf numeroAdivinado > numeroObjetivo Then
                    Console.WriteLine("El n�mero es menor. Intento #" & intentos)
                End If
            Else
                Console.WriteLine("Entrada no v�lida. Introduce un n�mero.")
            End If

        Loop While numeroAdivinado <> numeroObjetivo

        Return intentos
    End Function
End Module
