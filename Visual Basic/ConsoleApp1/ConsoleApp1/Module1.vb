Module Module1

    Sub Main()
        displaymsg()
        Dim a, b As Integer
        Console.WriteLine("enter the value")
        a = Console.ReadLine()
        b = Console.ReadLine()
        Add(a, b)
        Console.ReadLine()
    End Sub
    Sub displaymsg()
        Console.WriteLine("using sub procedure")
    End Sub
    Sub Add(ByVal a As Integer, ByVal b As Integer)
        Console.WriteLine("addition= " & a + b)
    End Sub

End Module
