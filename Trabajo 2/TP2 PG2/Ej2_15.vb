Module Ej2_15
    Sub main()
        Dim capital As Decimal
        Dim capitalacu As Decimal
        Dim saldo As Decimal
        Dim meses As UInt16
        Dim interes As Single = (36 / 100)
        Dim intmensual As Single
        Dim interes_acu As Single
        Console.Write("Ingrese capital: ")
        capital = Console.ReadLine()
        Console.Write("Ingrese cantidad de meses: ")
        meses = Console.ReadLine()
        saldo = capital
        For i = 1 To meses
            capitalacu = saldo
            intmensual = capitalacu * (interes / 12)
            saldo = capitalacu + intmensual
            interes_acu += intmensual
            Console.WriteLine("Mes: " & i & "      Capital: " & capitalacu & "      Interes: " & intmensual & "      Saldo: " & saldo)
        Next
        Console.WriteLine("Total interes ganado: " & interes_acu)
        Console.ReadKey()


    End Sub
End Module
