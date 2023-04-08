Module Module1

    Sub Main()

        Dim num, i As Integer
        Dim b As Boolean

        Console.WriteLine(" Prime Number From 1 to 100 = ")

        b = True

        While num <= 100
            b = True
            i = 2

            While i < num
                If num Mod i = 0 Then
                    b = False
                    GoTo break

                End If
                i += 1
            End While
break:
            If b Then
                Console.WriteLine(num)
            End If
            num += 1
        End While


        Console.ReadKey()

    End Sub

End Module
