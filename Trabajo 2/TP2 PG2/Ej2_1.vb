Module Ej2_1

    Sub Main()
        Dim a As Integer
        Dim b As Integer

        Console.Write("Ingrese a: ")
        a = Console.ReadLine()
        Console.Write("Ingrese b: ")
        b = Console.ReadLine()
        If (a = b) Then
            Console.WriteLine("Los valores son iguales")
        ElseIf (a > b) Then
            Console.WriteLine("El mayor es a: " & a & " y el menor es b: " & b)
        Else
            Console.WriteLine("El mayor es b: " & b & "  y el menor es a: " & a)
        End If
        Console.ReadKey()



    End Sub

End Module
