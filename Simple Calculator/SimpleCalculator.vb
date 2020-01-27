'Anthony Shore
'RCET0265 
'Spring 2020
'Simple Calculator
'https://github.com/shoranth/AVS-VS-S20

Module SimpleCalculator

    Sub Main()

        Dim firstNumber As Double
        Dim secondNumber As Double
        Dim usersOperation As Integer

        Console.WriteLine("This is a simple calculator.")
        Console.WriteLine("What is the FIRST number you would like in your calculation? Press enter when finished.")
        firstNumber = Console.ReadLine()

        Console.WriteLine("What is the SECOND number you would like in your calculation? Press enter when finished.")
        secondNumber = Console.ReadLine()

        Console.WriteLine("Please select an operation for your calculation.")
        Console.WriteLine("1: Add")
        Console.WriteLine("2: Subtract")
        Console.WriteLine("3: Multiply")
        Console.WriteLine("4: Divide")
        usersOperation = Console.ReadLine()

        If usersOperation = 1 Then
            Console.WriteLine(firstNumber + secondNumber)
        ElseIf usersOperation = 2 Then
            Console.WriteLine(firstNumber - secondNumber)
        ElseIf usersOperation = 3 Then
            Console.WriteLine(firstNumber * secondNumber)
        ElseIf usersOperation = 4 Then
            Console.WriteLine(firstNumber / secondNumber)
        Else
            Console.WriteLine("The value you entered is invalid. Please try again.")
        End If

        Console.ReadLine()

    End Sub

End Module
