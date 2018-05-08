Module Ej2_2
    Sub main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer


        Console.Write("Ingrese a: ")
        a = Console.ReadLine()
        Console.Write("Ingrese b: ")
        b = Console.ReadLine()
        Console.Write("Ingrese c: ")
        c = Console.ReadLine()


        If (a = b And a = c) Then
            Console.WriteLine("Los valores son iguales")
        ElseIf (a = b) Then
            If (a < c) Then
                Console.WriteLine("Los menores son a y b: " & a)
            Else
                Console.WriteLine("El menor es c: " & c)
            End If
        ElseIf (b = c) Then
            If (b < a) Then
                Console.WriteLine("Los menores son b y c: " & b)
            Else
                Console.WriteLine("El menor es a: " & a)
            End If
        ElseIf (a = c) Then
            If (a < b) Then
                Console.WriteLine("Los menores son a y c: " & a)
            Else
                Console.WriteLine("El menor es b: " & b)
            End If
        ElseIf (a < b And a < c) Then
            Console.WriteLine("El menor es a: " & a)
        ElseIf (b < a And b < c) Then
            Console.WriteLine("El menor es b: " & b)
        Else
            Console.WriteLine("El menor es c: " & c)
        End If

        Console.ReadKey()

    End Sub
End Module
