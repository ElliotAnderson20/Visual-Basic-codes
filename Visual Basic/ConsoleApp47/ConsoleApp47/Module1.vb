Module Module1

    Sub Main()
        Dim obj As New circle(2)
        obj.area()
        Console.ReadLine()
    End Sub
    Class circle
        Dim p As Double = 3.14
        Dim r, a As Double
        Public Sub New(ByVal i As Integer)
            r = i

        End Sub
        Sub area()
            a = p * r * r
            Console.WriteLine("area" & a)
        End Sub
    End Class

End Module
