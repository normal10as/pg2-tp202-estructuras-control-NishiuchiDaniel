Module Ej2_3
    Sub main()
        Dim a As Integer
        Dim b As Integer
        Dim posi As Int16
        For c As Int16 = 0 To 4
            Console.Write("Ingrese valor nº " & c + 1 & ": ")
            a = Console.ReadLine()
            If c = 0 Then
                b = a
            ElseIf (a > b) Then
                b = a
                posi = c + 1
            End If
        Next
        Select Case posi
            Case 1
                Console.WriteLine("El primer numero es el mayor valor")
            Case 2
                Console.WriteLine("El segundo numero es el mayor valor")
            Case 3
                Console.WriteLine("El tercer numero es el mayor valor")
            Case 4
                Console.WriteLine("El cuarto numero es el mayor valor")
            Case 5
                Console.WriteLine("El quinto numero es el mayor valor")
        End Select
        Console.ReadKey()
    End Sub
End Module
