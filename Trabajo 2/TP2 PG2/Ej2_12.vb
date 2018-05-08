Module Ej2_12
    Sub main()
        Dim a As UInt16 = 0
        Dim b As UInt16 = 1
        Dim c As UInt16 = 0
        For f = 0 To 19
            Console.WriteLine(c)
            c = a + b
            a = b
            b = c
        Next
        Console.ReadKey()
    End Sub
End Module
