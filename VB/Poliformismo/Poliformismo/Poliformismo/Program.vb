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
        Console.WriteLine("Círculo: Área = " & area)
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
        Console.WriteLine("Rectángulo: Área = " & area)
    End Sub
End Class

Module Program
    Sub Main()
        Dim formas As New List(Of FormaGeometrica)

        While True
            Console.WriteLine("Seleccione una forma geométrica:")
            Console.WriteLine("1. Círculo")
            Console.WriteLine("2. Rectángulo")
            Console.WriteLine("3. Salir")

            Dim opcion As Integer
            If Integer.TryParse(Console.ReadLine(), opcion) Then
                Select Case opcion
                    Case 1
                        Console.Write("Introduzca el radio del círculo: ")
                        Dim radio As Double
                        If Double.TryParse(Console.ReadLine(), radio) Then
                            formas.Add(New Circulo(radio))
                        Else
                            Console.WriteLine("Entrada no válida. Intente de nuevo.")
                        End If
                    Case 2
                        Console.Write("Introduzca el lado A del rectángulo: ")
                        Dim ladoA As Double
                        Console.Write("Introduzca el lado B del rectángulo: ")
                        Dim ladoB As Double
                        If Double.TryParse(Console.ReadLine(), ladoA) And Double.TryParse(Console.ReadLine(), ladoB) Then
                            formas.Add(New Rectangulo(ladoA, ladoB))
                        Else
                            Console.WriteLine("Entrada no válida. Intente de nuevo.")
                        End If
                    Case 3
                        Exit While
                    Case Else
                        Console.WriteLine("Opción no válida. Intente de nuevo.")
                End Select
            Else
                Console.WriteLine("Opción no válida. Intente de nuevo.")
            End If
        End While

        Console.WriteLine("Áreas de las formas ingresadas:")
        For Each forma In formas
            forma.CalcularArea()
        Next
    End Sub
End Module
