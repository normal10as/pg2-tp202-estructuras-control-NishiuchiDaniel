Module Ej2_4
    Sub main()
        Dim cantidad As Integer
        Dim precioUni As Double
        Dim descuento As Double
        Dim PorDesc As Int16
        Console.Write("Ingrese cantidad de productos: ")
        cantidad = Console.ReadLine()
        Console.Write("Ingrese precio unitario: ")
        precioUni = Console.ReadLine()
        If (cantidad >= 10 And cantidad <= 50) Then
            descuento = (cantidad * precioUni) * 5 / 100
            PorDesc = 5
        ElseIf (cantidad >= 51 And cantidad <= 250) Then
            descuento = (cantidad * precioUni) * 10 / 100
            PorDesc = 10
        ElseIf (cantidad >= 251) Then
            descuento = (cantidad * precioUni) * 20 / 100
            PorDesc = 20
        Else
            descuento = 0
            PorDesc = 0
        End If
        Console.WriteLine("Subtotal: " & cantidad * precioUni)
        Console.WriteLine("Porcentaje de descuento: " & PorDesc & "%")
        Console.WriteLine("Monto descontado: " & descuento)
        Console.WriteLine("Total: " & (cantidad * precioUni - descuento))
        Console.ReadKey()
    End Sub
End Module
