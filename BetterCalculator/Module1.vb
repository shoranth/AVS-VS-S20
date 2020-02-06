Module Module1

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userChoice As String
        Dim quitProgram As Boolean
        Dim promptUser1 As Boolean
        Dim promptUser2 As Boolean



        Do While quitProgram = False

            promptUser1 = True
            promptUser2 = True
            quitProgram = False

            Console.WriteLine("Please enter a number...")
            Do While promptUser1 = True
                Try
                    firstNumber = CInt(Console.ReadLine())
                    promptUser1 = False
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")
                    promptUser1 = True
                End Try
            Loop

            Console.WriteLine("Please enter a 2nd number...")
            Do While promptUser2 = True
                Try
                    secondNumber = CInt(Console.ReadLine())
                    promptUser2 = False
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")
                    promptUser2 = True
                End Try
            Loop

            Console.WriteLine("Please Choose an Option")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Subtract")
            Console.WriteLine("3. Multiply")
            Console.WriteLine("4. Divide")
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
                    Console.WriteLine(firstNumber - secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try

            ElseIf userChoice = "3" Then

                Try
                    Console.WriteLine(firstNumber * secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try

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

            If Console.ReadLine() = "q" Then
                quitProgram = True

            Else
                quitProgram = False
            End If

            Console.Clear()
        Loop
    End Sub

End Module
