Module Module1

    Sub Main()
        show()
        Dim a, b As Integer
        Console.WriteLine(" enter the two number")
        a = Console.ReadLine()
        b = Console.ReadLine()
        add(a, b)
        Console.WriteLine(" addition is =" & add(a, b))

        Console.ReadLine()
    End Sub
    Public Function show()
        Console.WriteLine(" this is a simple function")
    End Function
    Public Function add(ByVal i As Integer, ByVal j As Integer)
        Dim sum As Integer
        sum = i + j
        Return sum
    End Function



End Module
