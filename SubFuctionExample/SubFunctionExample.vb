'Anthony Shore
'RCET 
'Spring 2020
'Sub Function Example

Option Strict On
Option Explicit On

Module SubFunctionExample

    Sub Main()

        'Dim myNumber As Integer
        'myNumber = 7

        'Console.WriteLine("This is located in Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()

        'MySub(myNumber)
        'Console.WriteLine("This is located in Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()

        'myNumber = MyFunc(myNumber)
        'Console.WriteLine("This is located in Sub Main")
        'Console.WriteLine(myNumber)

        'doMath(7, 5, "Subtract")

        'For i = 1 To 50 Step 10
        showPattern(20, "TIM")
        'Next
        Console.ReadLine()


    End Sub

    Sub MySub(myNumber As Integer)

        'Dim myNumber As Integer
        'myNumber = 2 + myNumber    same as the line of code below
        myNumber += 2
        Console.WriteLine("This is located in Sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()



    End Sub

    Function MyFunc(myNumber As Integer) As Integer

        'Dim myNumber As Integer
        myNumber -= 93
        Console.WriteLine("Located in Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber

    End Function

    Sub doMath(firstNumber As Integer, secondNumber As Integer, operatorChoice As String)

        Dim result As Double

        If operatorChoice = "Add" Then
            result = firstNumber + secondNumber
        ElseIf operatorChoice = "Subtract" Then
            result = firstNumber - secondNumber
        ElseIf operatorChoice = "Multiply" Then
            result = firstNumber * secondNumber
        ElseIf operatorChoice = "Divide" Then
            result = firstNumber / secondNumber
        End If

        Console.WriteLine(result)

    End Sub

    Sub showPattern(length As Integer, character As String)

        'Dim character As String
        'character = "*"

        Dim pattern As String
        pattern = ""

        Console.WriteLine(Len(character))

        For index = 0 To length Step 1
            pattern &= character
            Console.WriteLine(pattern)
        Next

        For index = length To 0 Step -1
            pattern = Left(pattern, index * Len(character))
            Console.WriteLine(pattern)
        Next

    End Sub

End Module
