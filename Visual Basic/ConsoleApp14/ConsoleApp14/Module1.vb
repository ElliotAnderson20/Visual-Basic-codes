Module Module1

    Sub Main()
        Dim s As New student
        s.branch()
        s.year()
        Console.ReadLine()
    End Sub
    Class faculty
        Dim b As String = " computer "
        Sub branch()
            Console.WriteLine("branch =" & b)
        End Sub
    End Class
    Class student
        Inherits faculty
        Dim y As String = " second year "
        Sub year()
            Console.WriteLine("year =" & y)
        End Sub
    End Class

End Module
