
Module Module1
    Sub Main()
        Dim obj As New child
        Dim result As Integer
        result = obj.add(10, 5)
        Console.WriteLine("Overloaded Values of Class addition")
        Console.WriteLine("Result =" & result)
        Console.ReadLine()
    End Sub
End Module
Public Class parent
    Public Overridable Function add(ByVal i As Integer, ByVal j As Integer)
        Return (i + j)
    End Function
End Class
Public Class child
    Inherits parent
    Public Overrides Function add(ByVal i As Integer, ByVal j As Integer)
        Console.WriteLine("Result of Addition =" & MyBase.add(12, 18))
        Return (i + j)
    End Function
End Class
