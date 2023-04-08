Module Module1

    Sub Main()

        Dim n As String

        Console.WriteLine("Enter Your Name=")

        n = Console.ReadLine()

        Try

            If n.Length = 0 Then

                Throw New ApplicationException("Error = Please Fill Data")

            End If

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        Finally

            Console.WriteLine("Thank You")

        End Try

        Console.ReadLine()

    End Sub

End Module

