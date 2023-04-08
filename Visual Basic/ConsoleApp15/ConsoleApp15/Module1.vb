Module Module1

    Sub Main()
        Dim res As New addition
        Console.WriteLine("overloaded values pf class addition")
        Console.WriteLine(res.add(10))
        Console.WriteLine(res.add(35, 20))
        Console.ReadLine()

    End Sub
End Module
Public Class addition
        Public i, j As Integer
        Public Function add(ByVal i As Integer) As Integer
            Return i

        End Function
        Public Function add(ByVal i As Integer, ByVal j As Integer) As Integer
            Return i + j
        End Function
    End Class

