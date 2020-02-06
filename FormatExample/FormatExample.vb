Module FormatExample

    Sub Main()

        Dim value As Decimal
        value = CDec(10.05)
        value.ToString("C")

        'Console.WriteLine(value)
        'currency
        'Console.WriteLine(value.ToString("C"))
        'hexidecimal
        'Console.WriteLine(value.ToString("X"))

        'tooManySpaces()

        timesTable()

        Console.ReadLine()

    End Sub

    Sub tooManySpaces()

        Dim message As String
        message = "     Hello          "
        'no trim
        Console.WriteLine(Len(message))
        'trim litterly takes off the leading and following extra spaces of a string
        message = Trim(message)
        Console.WriteLine(Len(message))

    End Sub

    Sub timesTable()

        Dim result As Integer
        For i = 1 To 10
            For j = 1 To 10
                result = i * j
                Console.Write(result.ToString("C").PadLeft(8) & "  |")
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
