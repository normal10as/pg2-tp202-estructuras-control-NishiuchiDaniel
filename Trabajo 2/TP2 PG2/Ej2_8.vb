Module Ej2_8
    Sub main()

        Dim mes As Byte
        Dim anio As Int16
        Dim b As Integer
        Console.Write("Ingrese mes: ")
        mes = Console.ReadLine()
        If (mes = 2) Then
            Console.WriteLine("asd")
        End If
        Console.WriteLine()
        Console.ReadKey()
    End Sub

    Enum Meses As Byte
        Enero = 31
        Febrero = 30
        Marzo = 31
        Abril = 30
        Mayo = 31
        Junio = 30
        Julio = 31
        Agosto = 31
        Septiembre = 30
        Octubre = 31
        Noviembre = 30
        Diciembre = 31
    End Enum
End Module
