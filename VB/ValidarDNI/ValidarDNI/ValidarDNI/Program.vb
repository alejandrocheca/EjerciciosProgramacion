Imports System

Module Program
    Sub Main()
        Console.Write("Introduce un DNI: ")
        Dim dni As String = Console.ReadLine()

        If ValidarDNI(dni) Then
            Console.WriteLine("El DNI es válido.")
        Else
            Console.WriteLine("El DNI no es válido.")
        End If
    End Sub

    Function ValidarDNI(dni As String) As Boolean
        If String.IsNullOrEmpty(dni) OrElse dni.Length <> 9 Then
            Return False
        End If

        dni = dni.ToUpper() ' Convierte a mayúsculas para evitar errores de letra

        ' Extraer los números del DNI
        Dim numeros As String = dni.Substring(0, 8)
        Dim letra As String = dni.Substring(8, 1)

        If Not Integer.TryParse(numeros, CInt(numeros)) Then
            Return False
        End If

        ' Calcular la letra esperada
        Dim letraCalculada As Char = CalcularLetraDNI(numeros)

        ' Comparar la letra esperada con la letra proporcionada
        Return letraCalculada = letra(0)
    End Function

    Function CalcularLetraDNI(numero As Integer) As Char
        Dim letras As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim indice As Integer = numero Mod 23
        Return letras(indice)
    End Function
End Module
