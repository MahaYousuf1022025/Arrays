Module Module1

    Sub Main()
        Dim exammarks(6) As Integer
        Dim index As Integer
        Dim marks As Integer
        Dim Isfound As Boolean
        Dim x As Integer
        Dim i As Integer

        Console.WriteLine("enter your marks.")
        For index = 1 To 6
            marks = Console.ReadLine
            exammarks(index) = marks

        Next
        Console.WriteLine(exammarks)

        Isfound = False
        Console.WriteLine("Enter the value you want to search")

        x = Console.ReadLine
        i = 0
        While Isfound = False And i <= 5
            i = i + 1
            If exammarks(i) = x Then
                Isfound = True
            End If
        End While
        If Isfound = True Then
            Console.WriteLine("Your value is found")
        Else
            Console.WriteLine("Your value is not found")
        End If
        Console.ReadKey()









    End Sub

End Module
