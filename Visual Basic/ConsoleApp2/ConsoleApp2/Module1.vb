Module Module1

    Sub Main()
        Dim num As Integer
        Console.WriteLine("enter the number")
        num = Console.ReadLine
        factorial(num)
        Console.ReadLine()

    End Sub

    Sub factorial(ByVal num As Integer)
        Dim i, factorial As Integer
        factorial = 1
        For i = 1 To num
            factorial = factorial * i

        Next i
        Console.WriteLine("factroial " & factorial)
        Console.ReadLine()
    End Sub
End Module
