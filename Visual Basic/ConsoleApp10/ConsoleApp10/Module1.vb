Module Module1

    Sub Main()
        Dim obj As New syco
        obj.show()

    End Sub
    Public Class syco
        Public Function show()
            Console.WriteLine("this is base class ")
        End Function
        Protected Overrides Sub finalize()
            Console.WriteLine("destructor exectuing here ")
            Console.ReadLine()
        End Sub
    End Class

End Module
