Module Module1

    Sub Main()
        Dim i As Integer
        i = 1
        While (i <= 50)
            If ((i Mod 2) = 0) Then
                Console.WriteLine("even {0}", i)
            Else
                Console.WriteLine("odd {0}", i)
            End If
            i = i + 1
        End While
        Console.ReadLine()
    End Sub

End Module
