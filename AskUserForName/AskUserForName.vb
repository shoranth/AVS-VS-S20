'Anthony Shore
'RCET0265 
'Spring 2020
'Say My Name Assignment
'https://github.com/shoranth/AVS-VS-S20

Option Explicit On
Option Strict On

Module Module1

    Sub Main()

        'Declares variable to store user name
        Dim userName As String

        'Asks the user for their name
        Console.WriteLine("What is your name? Please type it in below. Then press enter when finished. ")

        'Stores the user's name in the userName variable
        userName = Console.ReadLine()
        
        'Responds to the user with their name
        Console.WriteLine("Thank you for getting me out of the Console " & userName & ". 10000 years will give you such a crick in the neck.")

        Console.ReadLine()
    End Sub

End Module
