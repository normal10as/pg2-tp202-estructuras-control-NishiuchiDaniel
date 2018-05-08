Module Ej2_11
    Sub main()
        Dim a As UInteger
        Dim c As Integer
        Dim par As Byte
        Dim impar As Byte
        Do
            Console.Write("Ingrese valor entero: ")
            a = Console.ReadLine()
            c = (-1) ^ a
            If c = 1 And a <> 0 Then
                par += 1
            ElseIf c = -1 And a <> 0 Then
                impar += 1
            End If

        Loop Until (a = 0)

        If par = 0 And impar <> 0 Then
            Console.WriteLine("Solo se ingresaron numeros impares: " & impar)
        ElseIf par <> 0 And impar = 0 Then
            Console.WriteLine("Solo se ingresaron numeros pares: " & par)
        Else
            Console.WriteLine("Los numeros pares ingresados son: " & par)
            Console.WriteLine("Los numeros impares ingresados son: " & impar)
        End If
        Console.ReadKey()
    End Sub
End Module
