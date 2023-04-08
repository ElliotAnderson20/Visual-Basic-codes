Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Console.WriteLine("enter the three number ")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        If (a > b) Then
            If (a > c) Then
                Console.WriteLine("the greater number is " & a)
            Else
                Console.WriteLine("greatest number is ")
            End If
        Else
            If (b > c) Then
                Console.WriteLine("greatest number is :" & b)
            Else
                Console.WriteLine("greatest number is " & c)
            End If

        End If
        Console.ReadLine()
    End Sub

End Module
