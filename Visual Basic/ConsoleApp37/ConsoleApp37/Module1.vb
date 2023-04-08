Module Module1

    Sub Main()
        Dim i As Integer
        While (i <= 50)
            If ((i Mod 2) = 0) Then
                Console.WriteLine(i & "even")
            Else
                Console.WriteLine(i & "odd ")
            End If
            i = i + 1
        End While
        Console.ReadLine()
    End Sub

End Module
