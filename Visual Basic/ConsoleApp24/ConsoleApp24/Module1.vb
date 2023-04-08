Module Module1

    Sub Main()
        Dim i As Integer
        Console.WriteLine("enter the number ")
        i = Console.ReadLine()
        If ((i Mod 2) = 0) Then
            Console.WriteLine("the number is even")
        Else
            Console.WriteLine("the number is odd")
        End If
        Console.ReadLine()
    End Sub

End Module
