Module Module1

    Sub Main()
        '4x4 array, 0-3
        Dim myArray(3) As Integer

        myArray(1) = 5

        myArray = {1, 2, 3, 4}

        Console.ReadLine()

    End Sub

    Private Sub InstantiateArrays()

        'Delcare a single-dimension array of 5 numbers
        Dim numbers(4) As Integer
        numbers = {1, 2, 4, 8, 16}

    End Sub

    Sub AnotherArrayExample()

        Dim infoArray() As String

        infoArray = Split("Hello, Goodbye, Pizza, Hungry, Ice Cream", ",")

        For Each thingy As String In inforArray
            Console.WriteLine(thingy)
            infoArray.Contains(thingy)

        Next

    End Sub


End Module
