Module Module1

    Sub Main()

        Dim age As Integer

        age = 20

        Try

            If (age > 18) Then

                Throw New ApplicationException("You can Vote")

            Else

                Throw New ApplicationException("You can not Vote")

            End If

        Catch ex As Exception

            ' Display the message.

            Console.WriteLine(ex.Message)

        Finally

            Console.WriteLine("Thank You")

        End Try

        Console.ReadLine()

    End Sub

End Module

