Module Module1

    Sub Main()
        Dim obj As New Sample
        obj.display()
        Console.ReadLine()


    End Sub
    Class sample
        Public Sub New()
            Console.WriteLine("this is constructor ")
        End Sub
        Sub display()
            Console.WriteLine("this is a method")
        End Sub
    End Class

End Module
