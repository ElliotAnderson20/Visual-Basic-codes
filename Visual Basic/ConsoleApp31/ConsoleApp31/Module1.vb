Module Module1

    Sub Main()
        Dim str As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim numberofvowels As Integer = 0
        For Each c As Char In str
            Select Case c
                Case "A", "E", "I", "O", "U"
                    numberofvowels = numberofvowels + 1

            End Select
        Next
        Console.WriteLine("the number of vowels is " & numberofvowels)
        Console.ReadLine()
    End Sub


End Module
