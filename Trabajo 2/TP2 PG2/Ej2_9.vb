Module Ej2_9


    Enum Unidades
        Metros = 1
        Centimetros = 2
        Yardas = 3
        Pulgadas = 4
        Pies = 5
    End Enum
    Sub main()

        Dim valor As Decimal
        Dim unidad As Unidades
        Console.WriteLine("A que unidad de medida desea convertir:" & vbCrLf & "1-Metros" & vbCrLf & "2-Centimetros" & vbCrLf & "3-Yardas" & vbCrLf & "4-Pulgadas" & vbCrLf & "5-Pies")
        unidad = Console.ReadLine()
        Console.WriteLine("Ingrese valor a convertir")
        valor = Console.ReadLine()


        Select Case unidad
            Case 1
                Console.WriteLine(valor & unidad.ToString)
                Console.WriteLine(valor * 100 & " Centimetros")
                Console.WriteLine((valor * 100) / 2.54 & " Pulgadas")
                Console.WriteLine((valor * 100) / 2.54 / 12 & " Pies")
                Console.WriteLine((valor * 100) / 2.54 / 12 / 3 & " Yardas")
            Case 2
                Console.WriteLine(valor & unidad.ToString)
                Console.WriteLine(valor / 100 & " Metros")
                Console.WriteLine(valor / 2.54 & " Pulgadas")
                Console.WriteLine(valor / 2.54 / 12 & " Pies")
                Console.WriteLine(valor / 2.54 / 12 / 3 & " Yardas")
            Case 3
                Console.WriteLine(valor & unidad.ToString)
                Console.WriteLine(valor * 3 * 12 * 2.54 * 100 & " Metros")
                Console.WriteLine(valor * 3 * 12 * 2.54 & " Centimetros")
                Console.WriteLine(valor * 3 * 12 & " Pulgadas")
                Console.WriteLine(valor * 3 & " Pies")
            Case 4
                Console.WriteLine(valor & unidad.ToString)
                Console.WriteLine(valor * 2.54 * 100 & " Metros")
                Console.WriteLine(valor * 2.54 & " Centimetros")
                Console.WriteLine((valor / 12) / 3 & " Yardas")
                Console.WriteLine(valor / 12 & " Pies")
            Case 5
                Console.WriteLine(valor & unidad.ToString)
                Console.WriteLine(valor * 12 * 2.54 * 100 & " Metros")
                Console.WriteLine(valor * 12 * 2.54 & " Centimetros")
                Console.WriteLine(valor / 3 & " Yardas")
                Console.WriteLine(valor * 12 & " Pulgadas")
            Case Else
                Console.WriteLine("Opcion Invalida")
        End Select

        Console.ReadKey()

    End Sub
End Module
