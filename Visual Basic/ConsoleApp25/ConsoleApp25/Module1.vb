Module Module1

    Sub Main()
        Dim perc As Integer
        Console.WriteLine("enter percentage:")
        perc = Console.ReadLine
        If (perc < 45) Then
            Console.WriteLine("fail")
        ElseIf ((perc > 45) And (perc < 60)) Then
            Console.WriteLine("pass ")
        ElseIf ((Perc > 60) And (perc < 75)) Then
            Console.WriteLine("first  class")
        ElseIf ((perc > 75) And (perc < 85)) Then
            Console.WriteLine(" distinction")
        Else
            Console.WriteLine("topp")
        End If
        Console.ReadLine()

    End Sub

End Module
