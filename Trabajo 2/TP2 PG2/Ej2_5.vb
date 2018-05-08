Module Ej2_5
    Sub main()

        Dim a As Int16

        Console.Write("Ingrese numero de mes: ")
        a = Console.ReadLine
        Select Case a
            Case 1
                Console.WriteLine("Enero")
            Case 2
                Console.WriteLine("Febrero")
            Case 3
                Console.WriteLine("Marzo")
            Case 4
                Console.WriteLine("Abril")
            Case 5
                Console.WriteLine("Mayo")
            Case 6
                Console.WriteLine("Junio")
            Case 7
                Console.WriteLine("Julio")
            Case 8
                Console.WriteLine("Agosto")
            Case 9
                Console.WriteLine("Septiembre")
            Case 10
                Console.WriteLine("Octubre")
            Case 11
                Console.WriteLine("Noviembre")
            Case 12
                Console.WriteLine("Diciembre")
            Case Else
                Console.WriteLine("Numero invalido")
        End Select
        Console.ReadKey()
    End Sub
End Module
