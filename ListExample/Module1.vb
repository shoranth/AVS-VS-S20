Option Compare Text

Module Module1

    Sub Main()

        Dim names As New List(Of String)
        Dim searchString As String

        names.Add("Tim")
        names.Add("Joe")

        'names.Add(Console.ReadLine())

        searchString = Console.ReadLine

        If names.Contains(searchString) = True Then
            Console.WriteLine("Yes, " & searchString & " is at index " & names.IndexOf(searchString))
        Else
            Console.WriteLine("Sorry, " & searchString & " was not found.")
        End If

        names.Contains(searchstring)

        For Each name In names
            Console.WriteLine(name)
        Next

        Console.ReadLine()

    End Sub

End Module
