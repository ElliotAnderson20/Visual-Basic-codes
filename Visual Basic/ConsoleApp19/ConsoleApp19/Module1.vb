Module Module1

    Dim f As New first

    Dim s As New second

    Dim t As New third

    Sub Main()

        f.display()

        s.display()

        t.display()

        Console.ReadLine()

    End Sub

End Module

Public Class first

    Public Sub display()

        Console.WriteLine("This is First Year")

    End Sub

End Class

Public Class second

    Inherits first

    Private Shadows Sub display()

        Console.WriteLine("This is Second Year")

    End Sub

End Class

Public Class third

    Inherits second

    Public Shadows Sub display()

        Console.WriteLine("This is Third Year")

    End Sub

End Class

