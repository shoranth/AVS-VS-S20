'Anthony Shore
'RCET0265
'Spring 2020
'Better Calculator
'https://github.com/shoranth/AVS-VS-S20

Option Compare Text

Module BetterCalculator

    Sub Main()
        Dim firstNumber As String
        Dim secondNumber As String
        Dim userChoice As String
        Dim quitProgram As Boolean
        Dim promptUser1 As Boolean
        Dim promptUser2 As Boolean

        userChoice = ""
        firstNumber = ""
        secondNumber = ""

        'While loop used to make the calculator run again until the user quits the program
        Do Until quitProgram = True

            promptUser1 = True
            promptUser2 = True
            quitProgram = False

            '1st number code
            Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")
            Console.WriteLine("Choose a number")
            Do While promptUser1 = True
                firstNumber = Console.ReadLine()
                If (firstNumber = "q") Then
                    Environment.Exit(0)
                End If
                Try
                    firstNumber = CInt(firstNumber)
                    Console.WriteLine("You entered " & Chr(34) & firstNumber & Chr(34))
                    promptUser1 = False
                Catch ex As Exception
                    Console.WriteLine("You entered " & Chr(34) & firstNumber & Chr(34))
                    Console.WriteLine("Please try again and enter a whole number")
                    promptUser1 = True
                End Try
            Loop

            Console.WriteLine()

            '2nd number code
            Console.WriteLine("Please enter a 2nd number...")
            Do While promptUser2 = True
                secondNumber = Console.ReadLine
                If (secondNumber = "q") Then
                    Environment.Exit(0)
                End If
                Try
                    secondNumber = CInt(secondNumber)
                    Console.WriteLine("You entered " & Chr(34) & secondNumber & Chr(34))
                    promptUser2 = False
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")
                    Console.WriteLine("You entered " & Chr(34) & secondNumber & Chr(34))
                    promptUser2 = True
                End Try
            Loop

            Console.WriteLine()

            'user selects which operation they want to perform on the entered numbers
            Do
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                userChoice = Console.ReadLine()
                If (userChoice = "q") Then
                    Environment.Exit(0)
                End If
                Console.WriteLine("You entered " & Chr(34) & userChoice & Chr(34))
            Loop Until (userChoice = "1") Or (userChoice = "2") Or (userChoice = "3") Or (userChoice = "4")

            'addition code
            If userChoice = "1" Then
                Try
                    Console.WriteLine(CDbl(firstNumber) + CDbl(secondNumber))
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try

                'Subtraction code
            ElseIf userChoice = "2" Then
                Try
                    Console.WriteLine(firstNumber - secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try

                'multiplication code
            ElseIf userChoice = "3" Then
                Try
                    Console.WriteLine(firstNumber * secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try

                'division code
            ElseIf userChoice = "4" Then
                Try
                    Console.WriteLine(firstNumber / secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try

            Else
                Console.WriteLine("Invalid Selection")
            End If
            Console.WriteLine("Press Enter To Run Again. Enter Q to quit.")

            'user enters q to quit the program or the program will repeat when enter is pressed
            If Console.ReadLine() = "q" Then
                Console.WriteLine("You entered ""Q""")
                Console.WriteLine("Have a nice day.")
                Console.WriteLine("Please press enter to close this window.")
                Console.ReadLine()
                quitProgram = True
            Else
                quitProgram = False
            End If

            Console.Clear()
        Loop
    End Sub

End Module
