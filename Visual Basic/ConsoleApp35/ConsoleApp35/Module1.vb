Module Module1

    Sub Main()
        Dim i, j, c As Integer
        i = 2
        c = 0
        j = 2
        While (i <= 100)
            While (j < i)
                If (i Mod j = 0) Then
                    Exit While

                ElseIf (i = j + 1) Then

                    Console.WriteLine(j)
                End If
                j = j + 1

            End While
            i = i + 1
        End While
        Console.ReadLine()
    End Sub

End Module
