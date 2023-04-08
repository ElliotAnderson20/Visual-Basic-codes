Module Module1

    Sub Main()
        Dim obj As box = New box()
        Dim vol As Integer
        vol = obj.volume(2, 4, 4)
        Console.WriteLine("length =" & obj.l)
        Console.WriteLine("breadth =" & obj.b)
        Console.WriteLine(" width =" & obj.h)
        Console.WriteLine(" volume =" & vol)
        Console.ReadLine()

    End Sub
    Class Box
        Public l, b, h As Integer
        Function Volume(ByVal i As Integer, ByVal j As Integer, ByVal k As Integer)
            Dim v As Integer
            l = i
            b = j
            h = k
            v = l * b * h
            Return v

        End Function
    End Class

End Module
