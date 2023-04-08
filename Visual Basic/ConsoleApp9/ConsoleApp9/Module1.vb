Module Module1

    Sub Main()
        Dim obj As New syco
        obj.show()
        Console.ReadLine()
    End Sub
    Public Class syco
        Public Function show()
            Console.WriteLine("this is a base class ")
        End Function
        Sub New()
            Console.WriteLine("constructor execution")
        End Sub
    End Class
End Module
