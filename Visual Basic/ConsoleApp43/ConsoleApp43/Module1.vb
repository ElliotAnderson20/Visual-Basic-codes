Module Module1

    Sub Main()
        Dim n1, n2, result, choice As Integer
        Console.WriteLine("menu:-/n1.add,/n2.sub,/n3.mul,/n4,divide")
        Console.WriteLine("enter the choice")
        choice = Console.ReadLine()
        Console.WriteLine("enter the number 1:")
        n1 = Console.ReadLine()
        Console.WriteLine("enter the number 2:-")
        n2 = Console.ReadLine()
        Select Case choice
            Case 1
                result = n1 + n2
                Console.WriteLine("result =" & result)
            Case 2
                result = n1 - n2
                Console.WriteLine("result =" & result)
            Case 3
                result = n1 * n2
                Console.WriteLine("result =" & result)
            Case 4
                result = n1 / n2
                Console.WriteLine("result =" & result)
                result = n1 Mod n2
                Console.WriteLine("result =" & result)
            Case Else
                Console.WriteLine("wrong option")
        End Select
        Console.ReadLine()

    End Sub

End Module
