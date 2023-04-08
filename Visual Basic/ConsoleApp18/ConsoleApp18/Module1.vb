Module Module1

    Sub Main()

        Dim p As New parent

        Dim c As New child

        p.use()

        c.use()

        Console.WriteLine("________________________________")

        p.disp()

        c.disp()

        Console.ReadLine()

    End Sub

    Public Class parent

        Public Sub disp()

            Console.WriteLine("Parent")

        End Sub

        Public Sub use()

            Me.disp()

        End Sub

    End Class

    Public Class child

        Inherits parent

        Public Shadows Sub disp()

            Console.WriteLine("Child")

        End Sub

    End Class

End Module

