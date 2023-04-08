Module Module1
    Sub Main()
        Dim s As New student
        s.branch()
        s.year()
        Console.ReadLine()
    End Sub
    Class faculty
        Dim b As String = "Computer"
        Sub branch()
            Console.WriteLine("Branch = " & b)
        End Sub
    End Class
    Class student
        Inherits faculty
        Dim y As String = "Second Year"
        Sub year()
            Console.WriteLine("Year = " & y)
        End Sub
    End Class
End Module