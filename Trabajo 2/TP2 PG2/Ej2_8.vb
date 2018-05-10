Module Ej2_8
    Enum Meses As Byte
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum

    Sub main()

        Dim mes As Meses
        Dim anio As Int16
        Console.Write("Ingrese mes: ")
        mes = Console.ReadLine()

        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine(mes.ToString & " Tiene 31 dias")
            Case 4, 6, 9, 11
                Console.WriteLine(mes.ToString & " Tiene 30 dias")
            Case 2
                Console.Write("Ingrese anio: ")
                anio = Console.ReadLine()
                If (((mes Mod 4) = 0 And (mes Mod 100) <> 0) Or mes Mod 400 = 0) Then
                    Console.WriteLine(mes.ToString & " Tiene 29 dias")
                Else
                    Console.WriteLine(mes.ToString & "Tiene 28 dias")
                End If
            Case Else
                Console.WriteLine("Fuera de rango")
        End Select

        Console.ReadKey()
    End Sub


End Module
