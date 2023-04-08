Module Module1

    Sub Main()
        Dim obj As New empinfo
        obj.showinfo()
        Console.ReadLine()

    End Sub
End Module
Public Class emppersonaldetails
    Dim name As String
    Dim address As String
    Public Overridable Function showinfo()
        Console.WriteLine("employee name " & name)
        Console.WriteLine("empolyee address " & address)

    End Function
End Class
Public Class empinfo
    Inherits emppersonaldetails
    Dim empid As Integer
    Dim salary As Integer
    Dim joindate As Date

    Overloads Function showinfo()
        MyBase.showinfo()

        Console.WriteLine(" employee id " & empid)
        Console.WriteLine("salary " & salary)
        Console.WriteLine("joindate" & joindate)

    End Function
End Class
