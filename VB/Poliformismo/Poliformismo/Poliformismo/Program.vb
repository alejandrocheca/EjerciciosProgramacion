Imports System

Public MustInherit Class FormaGeometrica
    Public MustOverride Sub CalcularArea()
End Class

Public Class Circulo
    Inherits FormaGeometrica
    Private Radio As Double

    Public Sub New(radio As Double)
        Me.Radio = radio
    End Sub

    Public Overrides Sub CalcularArea()
        Dim area As Double = Math.PI * Math.Pow(Radio, 2)
        Console.WriteLine("C�rculo: �rea = " & area)
    End Sub
End Class

Public Class Rectangulo
    Inherits FormaGeometrica
    Private LadoA As Double
    Private LadoB As Double

    Public Sub New(ladoA As Double, ladoB As Double)
        Me.LadoA = ladoA
        Me.LadoB = ladoB
    End Sub

    Public Overrides Sub CalcularArea()
        Dim area As Double = LadoA * LadoB
        Console.WriteLine("Rect�ngulo: �rea = " & area)
    End Sub
End Class

Module Program
    Sub Main()
        Dim formas As New List(Of FormaGeometrica)

        While True
            Console.WriteLine("Seleccione una forma geom�trica:")
            Console.WriteLine("1. C�rculo")
            Console.WriteLine("2. Rect�ngulo")
            Console.WriteLine("3. Salir")

            Dim opcion As Integer
            If Integer.TryParse(Console.ReadLine(), opcion) Then
                Select Case opcion
                    Case 1
                        Console.Write("Introduzca el radio del c�rculo: ")
                        Dim radio As Double
                        If Double.TryParse(Console.ReadLine(), radio) Then
                            formas.Add(New Circulo(radio))
                        Else
                            Console.WriteLine("Entrada no v�lida. Intente de nuevo.")
                        End If
                    Case 2
                        Console.Write("Introduzca el lado A del rect�ngulo: ")
                        Dim ladoA As Double
                        Console.Write("Introduzca el lado B del rect�ngulo: ")
                        Dim ladoB As Double
                        If Double.TryParse(Console.ReadLine(), ladoA) And Double.TryParse(Console.ReadLine(), ladoB) Then
                            formas.Add(New Rectangulo(ladoA, ladoB))
                        Else
                            Console.WriteLine("Entrada no v�lida. Intente de nuevo.")
                        End If
                    Case 3
                        Exit While
                    Case Else
                        Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
                End Select
            Else
                Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
            End If
        End While

        Console.WriteLine("�reas de las formas ingresadas:")
        For Each forma In formas
            forma.CalcularArea()
        Next
    End Sub
End Module
