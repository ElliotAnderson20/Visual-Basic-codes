Module Module1

    Sub Main()
        Dim num As Integer
        Console.WriteLine(" enter the palindrome ")
        num = Console.ReadLine()
        reverse(num)
        Console.ReadLine()

    End Sub
    Sub reverse(ByVal num As Integer)
        Dim number = num
        Dim result As Integer
        While number > 0
            num = number Mod 10
            result = result * 10 + num
            number = number / 10

        End While
        Console.WriteLine("" & result)
    End Sub


End Module
