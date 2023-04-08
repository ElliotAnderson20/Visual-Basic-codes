Module Module1

    Sub Main()
        Dim i As Integer
        Console.WriteLine("the armstrong number are")
        For i = 1 To 500 Step 1
            Dim sum, num, digit As Integer
            sum = 0
            num = i
            While (num > 0)
                digit = num Mod 10
                sum += (digit * digit * digit)
                num = num \ 10
            End While
            If (sum = i) Then
                Console.WriteLine(i)
            End If

        Next

        Console.ReadLine()

    End Sub

End Module
