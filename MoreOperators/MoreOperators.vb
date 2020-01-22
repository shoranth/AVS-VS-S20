'Anthony Shore
'RCET
'Sring 2020
'Math Operators 1-21-20

Option Explicit On
Option Strict On

Module MoreOperators

    Sub Main()
        'prompt user for a message
        'then display the message
        Dim userMessage As String

        'userMessage = "Hello"

        Console.WriteLine("Please Enter a message. Press enter when done.")

        userMessage = Console.ReadLine()

        Console.WriteLine("The user enetered: " & Chr(34) & userMessage & Chr(34) & " Great Job User!")

        Console.ReadLine()

    End Sub

End Module
