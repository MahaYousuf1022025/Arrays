Module Module1

    Sub Main()
        Dim binstr As Integer
        Dim total, count, Nextchar, power As Integer
        binstr = Console.ReadLine
        total = 0
        For count = Len(binstr) To 1 Step -1
            Nextchar = Mid(binstr, count)
            power = Len(binstr) - count
            total = total + (Val(Nextchar) * 2 ^ power)

        Next

        Console.WriteLine(total)
        Console.ReadKey()







    End Sub

End Module
