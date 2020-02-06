'Anthony Shore
'RCET0265 
'Spring 2020
'Simple Calculator
'https://github.com/shoranth/AVS-VS-S20

Option Compare Text
Option Strict On
Option Explicit On

Module SimpleCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userChoice As String
        Dim quitProgram As Boolean
        Dim promtUser As Boolean

        promtUser = True
        quitProgram = False

        Do While quitProgram = False

        Console.WriteLine("Please enter a number...")
            Do While promtUser = True
                Try
                    firstNumber = CInt(Console.ReadLine())
                    promtUser = False
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")
                    promtUser = True
                End Try
            Loop

         Console.WriteLine("Please enter a 2nd number...")
                Try
                    secondNumber = CInt(Console.ReadLine())
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")
                End Try

        Console.WriteLine("Please Choose an Option")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Multiply")
        userChoice = Console.ReadLine()

        If userChoice = "1" Then

        Try
                Console.WriteLine(firstNumber + secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try

        ElseIf userChoice = "2" Then

                Try
                Console.WriteLine(firstNumber * secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try

        Else

                Console.WriteLine("Invalid Selection")

            End If

            Console.WriteLine("Have a nice day...")
            Console.WriteLine("Press Enter To Run Again. Enter Q to quit.")

            If Console.ReadLine() = "q" Then
                quitProgram = True

        Else
                quitProgram = False
            End If

            Console.Clear()
        Loop

    End Sub

End Module
