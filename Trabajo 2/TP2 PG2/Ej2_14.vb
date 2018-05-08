Module Ej2_14
    Sub main()
        Dim cantidad As Integer
        Dim precioUni As Double
        Dim descuento As Double
        Dim total As Double
        Dim subtotgral As Double
        Dim descgral As Double
        Do
            Console.Write("Ingrese cantidad de productos: ")
            cantidad = Console.ReadLine()
            Console.Write("Ingrese precio unitario: ")
            precioUni = Console.ReadLine()
            Select Case cantidad
                Case 1 To 9
                    descuento = 0
                    total = cantidad * precioUni - descuento
                    Console.WriteLine("Subtotal: " & cantidad * precioUni)
                    Console.WriteLine("Porcentaje de descuento: 0%")
                    Console.WriteLine("Monto descontado: " & descuento)
                    Console.WriteLine("Total: " & total)
                    Console.WriteLine("----------------------------")
                Case 10 To 50
                    descuento = (cantidad * precioUni) * 5 / 100
                    total = cantidad * precioUni - descuento
                    Console.WriteLine("Subtotal: " & cantidad * precioUni)
                    Console.WriteLine("Porcentaje de descuento: 5%")
                    Console.WriteLine("Monto descontado: " & descuento)
                    Console.WriteLine("Total: " & total)
                    Console.WriteLine("----------------------------")
                Case 51 To 250
                    descuento = (cantidad * precioUni) * 10 / 100
                    total = cantidad * precioUni - descuento
                    Console.WriteLine("Subtotal: " & cantidad * precioUni)
                    Console.WriteLine("Porcentaje de descuento: 10%")
                    Console.WriteLine("Monto descontado: " & descuento)
                    Console.WriteLine("Total: " & total)
                    Console.WriteLine("----------------------------")
                Case 251 To cantidad
                    descuento = (cantidad * precioUni) * 20 / 100
                    total = cantidad * precioUni - descuento
                    Console.WriteLine("Subtotal: " & cantidad * precioUni)
                    Console.WriteLine("Porcentaje de descuento: 20%")
                    Console.WriteLine("Monto descontado: " & descuento)
                    Console.WriteLine("Total: " & total)
                    Console.WriteLine("----------------------------")
                Case Else

            End Select
            If cantidad <> 0 And precioUni <> 0 Then
                descgral = descgral + descuento
                subtotgral = subtotgral + (cantidad * precioUni)
            End If

        Loop Until (cantidad = 0 Or precioUni = 0)

        Console.WriteLine("----------------------------")
        Console.WriteLine("Subtotal general: " & subtotgral)
        Console.WriteLine("Monto descontado total: " & descgral)
        Console.WriteLine("Total general: " & subtotgral - descgral)

        Console.ReadKey()


    End Sub
End Module
