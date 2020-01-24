'Anthony Shore
'RCET0265 
'Spring 2020
'Say My Name Again Assignment
'https://github.com/shoranth/AVS-VS-S20

Option Explicit On
Option Strict On
'makes the program not case sensative
Option Compare Text


Module SayMyNameAgain

    Sub Main()
        Dim usersName As String
        'Dim movieQuoteAnswer As String

        Console.WriteLine("Hello user. What is your first name?")
        usersName = Console.ReadLine()

        If usersName = "Anthony" Then
            Console.WriteLine("Welcome Admin. You have all control and are all powerful. To proceed, please name the movie this quote is from.  Death is the only adventure you have left!")
        ElseIf usersName = "Emily" Then
            Console.WriteLine("Welcome " & usersName & ". You are 2nd in command. Can you name the movie this quote is from? : I killed Mufasa!")
        ElseIf usersName = "Joe" Then
            Console.WriteLine("Welcome " & usersName & ". I don't like you. I am not even sure why admin put you into this database. What movie is the following quote from? All it takes is faith, trust, and pixie dust.")
        Else
            Console.WriteLine("You are not a verified user. Please come back with a user I recogize.")
        End If

        Console.ReadLine()

    End Sub

End Module
