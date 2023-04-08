Module Module1

    Sub Main()
        Dim anArray() As Integer = {1, 3, 5, 7, 9}
        Dim arrayitem As Integer
        For Each arrayitem In anArray
            Console.WriteLine(arrayitem)
        Next
        Console.ReadLine()
    End Sub

End Module
