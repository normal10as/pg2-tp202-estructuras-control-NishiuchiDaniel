Module Ej2_10
    Sub main()

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim contador As Byte
        Console.Write("Ingrese primer valor: ")
        a = Console.ReadLine()
        Console.Write("Ingrese segundo valor: ")
        b = Console.ReadLine()
        c = a
        Console.WriteLine("Estructura Do While - Loop")
        Do While (c <= b)
            If Math.IEEERemainder(c, 5) = 0 Then
                contador += 1
            End If
            c += 1
        Loop
        Console.WriteLine("La cantidad de multiplos de 5 es: " & contador)
        Console.ReadKey()

        c = a
        contador = 0
        Console.WriteLine("Estructura Do Until - Loop")
        Do Until (c > b)
            If Math.IEEERemainder(c, 5) = 0 Then
                contador += 1
            End If
            c += 1
        Loop
        Console.WriteLine("La cantidad de multiplos de 5 es: " & contador)
        Console.ReadKey()

        c = a
        contador = 0
        Console.WriteLine("Estructura Do Loop - While")
        Do
            If Math.IEEERemainder(c, 5) = 0 Then
                contador += 1
            End If
            c += 1
        Loop While (c <= b)
        Console.WriteLine("La cantidad de multiplos de 5 es: " & contador)
        Console.ReadKey()


        c = a
        contador = 0
        Console.WriteLine("Estructura Do Loop - Until")
        Do
            If Math.IEEERemainder(c, 5) = 0 Then
                contador += 1
            End If
            c += 1
        Loop Until (c > b)
        Console.WriteLine("La cantidad de multiplos de 5 es: " & contador)
        Console.ReadKey()




    End Sub
End Module
