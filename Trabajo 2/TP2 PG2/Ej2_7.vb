Module Ej2_7
    Sub main()

        Dim angulo As Int16

        Console.Write("Ingrese angulo entre 0º y 360º: ")
        angulo = Console.ReadLine()

        Select Case angulo
            Case 0 To 89
                Console.WriteLine("Agudo")
            Case 90
                Console.WriteLine("Recto")
            Case 91 To 179
                Console.WriteLine("Obtuso")
            Case 180
                Console.WriteLine("Llano")
            Case 181 To 359
                Console.WriteLine("Concavo")
            Case Else
                Console.WriteLine("ERROR")
        End Select

        Console.ReadKey()

    End Sub
End Module
