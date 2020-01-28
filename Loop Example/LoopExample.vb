'Anthony Shore
'RCET 
'Spring 2020
'Loop Example


Option Explicit On
Option Strict On
Option Compare Binary

Module LoopExample

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        firstNumber = 5
        secondNumber = 7

        result = firstNumber + secondNumber

        For loopCount = 0 To 25 Step 5
            result = result + 3
            Console.WriteLine(loopCount)
        Next

        Console.WriteLine(result)

        Console.ReadLine()




    End Sub

End Module
