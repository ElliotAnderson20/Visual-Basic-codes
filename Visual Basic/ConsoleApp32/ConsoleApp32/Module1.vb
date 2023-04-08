Module Module1

    Sub Main()
        Dim num1, num2, result, choice As Integer
        Do
            Console.WriteLine("/n 1.add,/n2.sub,/n 3.mul,/n 4.div,/n5.exit")
            Console.WriteLine(" enter the choice :")
        choice = Console.ReadLine()
        Console.WriteLine("enter the two numbers ")
        num1 = Console.ReadLine()
            num2 = Console.ReadLine()
            Select Case choice
                Case 1
                    result = num1 + num2
                    Console.WriteLine("the addition is :" & result)
                Case 2
                    result = num1 - num2
                    Console.WriteLine("the subtraction is :" & result)
                Case 3
                    result = num1 * num2
                    Console.WriteLine("the multiplication is :" & result)
                Case 4
                    result = num1 / num2
                    Console.WriteLine(" the division is :" & result)
                Case 5
                    Exit Sub
                Case Else
                    Console.WriteLine(" wrong option ")

            End Select
            Console.ReadLine()
        Loop

    End Sub

End Module
