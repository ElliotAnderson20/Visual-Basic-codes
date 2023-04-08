Module Module1

    Sub Main()
        Dim n As Integer
        Console.WriteLine(" enter the number ")
        n = Console.ReadLine()
        Console.WriteLine(" result =")
        Console.WriteLine(fact(n))
        Console.ReadLine()
    End Sub
    Function fact(ByVal n As Integer)
        If n = 0 Then
            fact = 1
        Else
            fact = n * fact(n - 1)

        End If
    End Function

End Module
