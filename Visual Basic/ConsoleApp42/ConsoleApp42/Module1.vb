Module Module1

    Sub Main()
        Dim a, b, c As Integer

        Console.WriteLine("enter three numbers")
        a = Val(Console.ReadLine())
        b = Val(Console.ReadLine())
        c = Val(Console.ReadLine())
        If (a > b) Then
            If (a > c) Then
                Console.WriteLine("the a is greater" & a)
            Else
                Console.WriteLine("the c is greater " & c)
            End If
        ElseIf (b > c) Then
            Console.WriteLine("the b is greater " & b)
        Else
            Console.WriteLine("the c is greater " & c)
        End If
        Console.ReadLine()

    End Sub

End Module
