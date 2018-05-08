Module Ej2_6
    Sub main()
        Dim cantidad As Integer
        Dim precioUni As Double
        Dim descuento As Double
        Dim PorDesc As Int16
        Console.Write("Ingrese cantidad de productos: ")
        cantidad = Console.ReadLine()
        Console.Write("Ingrese precio unitario: ")
        precioUni = Console.ReadLine()
        Select Case cantidad
            Case 10 To 50
                descuento = (cantidad * precioUni) * 5 / 100
                PorDesc = 5
            Case 51 To 250
                descuento = (cantidad * precioUni) * 10 / 100
                PorDesc = 10
            Case 251 To cantidad
                descuento = (cantidad * precioUni) * 20 / 100
                PorDesc = 20
            Case Else
                descuento = 0
                PorDesc = 0
        End Select

        Console.WriteLine("Subtotal: " & cantidad * precioUni)
        Console.WriteLine("Porcentaje de descuento: " & PorDesc & "%")
        Console.WriteLine("Monto descontado: " & descuento)
        Console.WriteLine("Total: " & (cantidad * precioUni - descuento))
        Console.ReadKey()


    End Sub
End Module
