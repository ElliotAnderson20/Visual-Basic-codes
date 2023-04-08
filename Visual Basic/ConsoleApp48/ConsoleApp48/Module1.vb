
Module Module1
    Sub Main()
        Dim obj As New details
        obj.show()
        Console.ReadLine()
    End Sub
End Module
Public Class student
    Public branch As String = "Computer"
End Class
Public Class details
    Inherits student
    Public Function show()
        Console.WriteLine("Branch = " & branch)
        Return 0
    End Function
End Class
