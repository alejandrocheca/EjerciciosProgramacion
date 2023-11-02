Imports System
Imports System.Collections.Generic

Module Program
    Sub Main()
        Console.Write("Ingrese la cantidad de números: ")
        Dim cantidad As Integer = Integer.Parse(Console.ReadLine())
        Dim array As New List(Of Integer)

        For i As Integer = 1 To cantidad
            Console.Write("Ingrese el número " & i & ": ")
            Dim numero As Integer = Integer.Parse(Console.ReadLine())
            array.Add(numero)
        Next

        Console.WriteLine("Array original:")
        PrintArray(array)

        BurbujaASC(array)

        Console.WriteLine("Array ordenado ascendentemente:")
        PrintArray(array)

        BurbujaDESC(array)

        Console.WriteLine("Array ordenado descendentemente:")
        PrintArray(array)
    End Sub

    Sub BurbujaASC(ByRef array As List(Of Integer))
        Dim n As Integer = array.Count
        Dim swapped As Boolean

        For i As Integer = 0 To n - 2
            swapped = False

            For j As Integer = 0 To n - i - 2
                If array(j) > array(j + 1) Then
                    ' Intercambiar los elementos
                    Dim temp As Integer = array(j)
                    array(j) = array(j + 1)
                    array(j + 1) = temp
                    swapped = True
                End If
            Next

            ' Si no se ha realizado ningún intercambio en esta pasada, la lista ya está ordenada
            If Not swapped Then
                Exit For
            End If
        Next
    End Sub

    Sub BurbujaDESC(ByRef array As List(Of Integer))
        Dim n As Integer = array.Count
        Dim swapped As Boolean

        For i As Integer = 0 To n - 2
            swapped = False

            For j As Integer = 0 To n - i - 2
                If array(j) < array(j + 1) Then
                    ' Intercambiar los elementos
                    Dim temp As Integer = array(j)
                    array(j) = array(j + 1)
                    array(j + 1) = temp
                    swapped = True
                End If
            Next

            ' Si no se ha realizado ningún intercambio en esta pasada, la lista ya está ordenada
            If Not swapped Then
                Exit For
            End If
        Next
    End Sub

    Sub PrintArray(ByVal array As List(Of Integer))
        For Each element As Integer In array
            Console.Write(element & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
