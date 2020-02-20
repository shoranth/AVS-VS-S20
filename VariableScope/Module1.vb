Option Explicit On
Option Strict On

Module Module1
    Dim aName As String = "Pete"

    Sub Main()

        Dim aNumber As Integer
        Dim anOtherName As String
        aNumber = 5
        aName = "Chucky"
        anOtherName = "Jason"
        'Console.WriteLine(aNumber)
        Console.WriteLine(aName)
        Console.WriteLine(anOtherName)
        mySub()
        'Console.WriteLine(aNumber)
        Console.WriteLine(aName)
        Console.WriteLine(anOtherName)
        Console.ReadLine()

    End Sub

    Sub mySub()

        Dim aNumber As Integer
        Dim anOtherName As String
        aNumber = 3
        aName = "Billy"
        anOtherName = "Freddy"

    End Sub
End Module
