Module Module1

    Sub Main()
        fibonacci(10)
        Console.ReadLine()
    End Sub
    Sub fibonacci(ByVal n As Integer)
        Dim a As Integer = 0
        Dim b As Integer = 1
        For i = 0 To n - 1
            Dim temp As Integer
            temp = a
            a = b
            b = temp + b
            Console.WriteLine(a)

        Next
    End Sub

End Module
