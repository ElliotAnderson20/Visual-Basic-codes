Module Module1

    Sub Main()
        Dim grade As Char
        Console.WriteLine("enter your grades ")
        grade = Console.ReadLine()
        Select Case grade
            Case " A "
                Console.WriteLine("very good")
            Case " B "
                Console.WriteLine("good")
            Case " C "
                Console.WriteLine(" poor ")
            Case " D "
                Console.WriteLine(" fail ")
                End
                Console.ReadLine()
        End Select
    End Sub

End Module
