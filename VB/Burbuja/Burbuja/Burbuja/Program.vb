Module Program
    Sub Main()
        Dim array() As Integer = {5, 2, 9, 1, 3}
        Dim n As Integer = array.Length

        Console.WriteLine("Array original:")
        PrintArray(array, n)

        Burbuja(array, n)

        Console.WriteLine("Array ordenado:")
        PrintArray(array, n)
    End Sub

    Sub Burbuja(ByRef arr() As Integer, ByVal n As Integer)
        Dim swapped As Boolean

        For i As Integer = 0 To n - 2
            swapped = False

            For j As Integer = 0 To n - i - 2
                If arr(j) > arr(j + 1) Then
                    ' Intercambiar los elementos
                    Dim temp As Integer = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                    swapped = True
                End If
            Next

            ' Si no se ha realizado ningún intercambio en esta pasada, el arreglo ya está ordenado
            If Not swapped Then
                Exit For
            End If
        Next
    End Sub

    Sub PrintArray(ByVal arr() As Integer, ByVal n As Integer)
        For i As Integer = 0 To n - 1
            Console.Write(arr(i) & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
